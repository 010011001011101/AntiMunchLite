using System;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AntiMunchLite.BugFix
{
  public class MyNumericInput : TextBox
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
        Text = value.ToString(CultureInfo.InvariantCulture);

        _OnValueChanged();
      }
    }

    private bool _InputError;
    private decimal _PreviousValue;

    private string _RegEx =>
      RepeatingDigitsCount == 0
        ? @"^(-?[\s\d]+)?$"
        : $"^(-?[\\s\\d]+([.,]\\d{{0,{RepeatingDigitsCount}}})?)?$";

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
      ValueChanged?.Invoke(this, new EventArgs());
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

    protected override void OnKeyUp(KeyEventArgs e)
    {
      if(e.KeyCode == Keys.Enter)
      {
        e.Handled = true;
        Parent.Focus();
      }

      base.OnKeyUp(e);
    }

  }
}