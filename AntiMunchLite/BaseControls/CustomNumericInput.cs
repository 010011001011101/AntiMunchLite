using System;
using System.Windows.Forms;

namespace AntiMunchLite.BaseControls
{
  public class CustomNumericInput : TextBox
  {
    public int? Minimum { get; set; }
    public int? Maximum { get; set; }

    private readonly ToolTip _ToolTip = new ToolTip();

    private string _ToolTipStr;
    public string ToolTip
    {
      get => _ToolTipStr;
      set => _ToolTip.SetToolTip(this, _ToolTipStr = value);
    }

    public event EventHandler ValueChanged;

    private void _OnValueChanged() => ValueChanged?.Invoke(this, new EventArgs());

    private int _Value;
    public int Value
    {
      get => _Value;
      set
      {
        Text = value.ToString();

        if (_Value != value)
        {
          _Value = value;
          _OnValueChanged();
        }
      }
    }

    private int _Parse(string str, out string parseDescription)
    {
      if (int.TryParse(str, out var intValue))
        parseDescription = intValue.ToString();
      else
        intValue = SimpleParser.Parse(str, out parseDescription);
        
      return _ApplyRange(intValue, ref parseDescription);
    }

    private int _ApplyRange(int intValue, ref string parseDescription)
    {
      if (Maximum.HasValue && intValue > Maximum.Value)
      {
        parseDescription += $" > MAX[{Maximum.Value}] = {Maximum.Value}";
        return Maximum.Value;
      }
      if (Minimum.HasValue && intValue < Minimum.Value)
      {
        parseDescription += $" < MIN[{Minimum.Value}] = {Minimum.Value}";
        return Minimum.Value;
      }

      return intValue;
    }

    protected override void OnLostFocus(EventArgs e)
    {
      Value = _Parse(Text, out var parseDescription);
      _ToolTip.SetToolTip(this, $"{_ToolTipStr} [{parseDescription}]");

      base.OnLostFocus(e);
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

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        _ToolTip.Dispose();

      base.Dispose(disposing);
    }
  }
}