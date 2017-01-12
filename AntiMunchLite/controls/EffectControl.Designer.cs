﻿namespace AntiMunchLite
{
  partial class EffectControl
  {
    /// <summary> 
    /// Требуется переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Обязательный метод для поддержки конструктора - не изменяйте 
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.EffectName = new System.Windows.Forms.TextBox();
      this.RemainTime = new AntiMunchLite.BugFix.MyNumericInput();
      this.DelBtn = new System.Windows.Forms.Button();
      this.TableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 3;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.TableLayoutPanel.Controls.Add(this.RemainTime, 1, 0);
      this.TableLayoutPanel.Controls.Add(this.DelBtn, 2, 0);
      this.TableLayoutPanel.Controls.Add(this.EffectName, 0, 0);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 1;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(263, 29);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // EffectName
      // 
      this.EffectName.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.EffectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.EffectName.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.EffectName.Location = new System.Drawing.Point(3, 4);
      this.EffectName.Name = "EffectName";
      this.EffectName.Size = new System.Drawing.Size(193, 20);
      this.EffectName.TabIndex = 0;
      this.EffectName.Text = "hhhhgggg";
      this.EffectName.TextChanged += new System.EventHandler(this.EffectName_TextChanged);
      // 
      // RemainTime
      // 
      this.RemainTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.RemainTime.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.RemainTime.Location = new System.Drawing.Point(199, 1);
      this.RemainTime.Margin = new System.Windows.Forms.Padding(0);
      this.RemainTime.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
      this.RemainTime.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.RemainTime.Name = "RemainTime";
      this.RemainTime.RepeatingDigitsCount = ((uint)(0u));
      this.RemainTime.Size = new System.Drawing.Size(44, 27);
      this.RemainTime.TabIndex = 1;
      this.RemainTime.Text = "0";
      this.RemainTime.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.RemainTime.ValueChanged += new System.EventHandler(this.RemainTime_ValueChanged);
      // 
      // DelBtn
      // 
      this.DelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.DelBtn.Location = new System.Drawing.Point(243, 1);
      this.DelBtn.Margin = new System.Windows.Forms.Padding(0);
      this.DelBtn.Name = "DelBtn";
      this.DelBtn.Size = new System.Drawing.Size(20, 27);
      this.DelBtn.TabIndex = 2;
      this.DelBtn.Text = "X";
      this.DelBtn.UseVisualStyleBackColor = true;
      this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
      // 
      // EffectControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Transparent;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.TableLayoutPanel);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "EffectControl";
      this.Size = new System.Drawing.Size(263, 29);
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.TextBox EffectName;
    private BugFix.MyNumericInput RemainTime;
    private System.Windows.Forms.Button DelBtn;
  }
}
