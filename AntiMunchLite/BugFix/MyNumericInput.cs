using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace AntiMunchLite.BugFix
{
  public class MyNumericInput : System.Windows.Forms.TextBox
  {
    public decimal Minimum { get; set; }
    public decimal Maximum { get; set; }
    public uint RepeatingDigitsCount { get; set; }

    public event EventHandler ValueChanged;

    public decimal Value
    {
      get
      {
        return string.IsNullOrWhiteSpace(Text)
          ? 0
          : Convert.ToDecimal(Text);
      }
      set
      {
        Text = value.ToString();

        _OnValueChanged();
      }
    }

    private bool _InputError;
    private decimal _PreviousValue;
    private string _RegEx
    {
      get
      {
        return RepeatingDigitsCount == 0
          ? @"^(-?[\s\d]+)?$"
          : string.Format("^(-?[\\s\\d]+([.,]\\d{{0,{0}}})?)?$", RepeatingDigitsCount);
      }
    }

    protected override void OnEnter(EventArgs e)
    {
      if (!_InputError)
        _PreviousValue = Value;
      base.OnEnter(e);
    }

    protected override void OnValidated(EventArgs e)
    {
      base.OnValidated(e);

      if (_PreviousValue != Value)
        _OnValueChanged();
    }

    private void _OnValueChanged()
    {
      var handler = ValueChanged;
      if (handler != null) handler(this, new EventArgs());
    }

    protected override void OnValidating(CancelEventArgs e)
    {
      base.OnValidating(e);

      if (Regex.IsMatch(Text, _RegEx))
      {
        var value = Value;

        if (value > Maximum)
          Value = Maximum;
        else if (value < Minimum)
          Value = Minimum;
        else
        {
          _InputError = false;
          return;
        }
      }

      e.Cancel = true;
      _InputError = true;
    }
  }
}