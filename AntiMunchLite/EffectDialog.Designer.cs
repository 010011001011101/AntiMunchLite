﻿namespace AntiMunchLite
{
  partial class EffectDialog
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.EffectName = new System.Windows.Forms.TextBox();
      this.RemainTime = new AntiMunchLite.BugFix.MyNumericInput();
      this.TypePanel = new System.Windows.Forms.FlowLayoutPanel();
      this.IsBuff = new System.Windows.Forms.RadioButton();
      this.IsDebuff = new System.Windows.Forms.RadioButton();
      this.OkBtn = new System.Windows.Forms.Button();
      this.CancelBtn = new System.Windows.Forms.Button();
      this.TableLayoutPanel.SuspendLayout();
      this.TypePanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 2;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.TableLayoutPanel.Controls.Add(this.EffectName, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.RemainTime, 1, 0);
      this.TableLayoutPanel.Controls.Add(this.TypePanel, 0, 1);
      this.TableLayoutPanel.Controls.Add(this.OkBtn, 0, 2);
      this.TableLayoutPanel.Controls.Add(this.CancelBtn, 1, 2);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 3;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(218, 86);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // EffectName
      // 
      this.EffectName.Dock = System.Windows.Forms.DockStyle.Top;
      this.EffectName.Location = new System.Drawing.Point(3, 3);
      this.EffectName.Name = "EffectName";
      this.EffectName.Size = new System.Drawing.Size(152, 20);
      this.EffectName.TabIndex = 0;
      // 
      // RemainTime
      // 
      this.RemainTime.Dock = System.Windows.Forms.DockStyle.Top;
      this.RemainTime.Location = new System.Drawing.Point(161, 3);
      this.RemainTime.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
      this.RemainTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.RemainTime.Name = "RemainTime";
      this.RemainTime.RepeatingDigitsCount = ((uint)(0u));
      this.RemainTime.Size = new System.Drawing.Size(54, 20);
      this.RemainTime.TabIndex = 1;
      this.RemainTime.Text = "10";
      this.RemainTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // TypePanel
      // 
      this.TableLayoutPanel.SetColumnSpan(this.TypePanel, 2);
      this.TypePanel.Controls.Add(this.IsDebuff);
      this.TypePanel.Controls.Add(this.IsBuff);
      this.TypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TypePanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.TypePanel.Location = new System.Drawing.Point(3, 29);
      this.TypePanel.Name = "TypePanel";
      this.TypePanel.Size = new System.Drawing.Size(212, 24);
      this.TypePanel.TabIndex = 2;
      // 
      // IsBuff
      // 
      this.IsBuff.AutoSize = true;
      this.IsBuff.Checked = true;
      this.IsBuff.Location = new System.Drawing.Point(81, 3);
      this.IsBuff.Name = "IsBuff";
      this.IsBuff.Size = new System.Drawing.Size(54, 17);
      this.IsBuff.TabIndex = 0;
      this.IsBuff.TabStop = true;
      this.IsBuff.Text = "Бафф";
      this.IsBuff.UseVisualStyleBackColor = true;
      // 
      // IsDebuff
      // 
      this.IsDebuff.AutoSize = true;
      this.IsDebuff.Location = new System.Drawing.Point(141, 3);
      this.IsDebuff.Name = "IsDebuff";
      this.IsDebuff.Size = new System.Drawing.Size(68, 17);
      this.IsDebuff.TabIndex = 1;
      this.IsDebuff.Text = "Дебафф";
      this.IsDebuff.UseVisualStyleBackColor = true;
      // 
      // OkBtn
      // 
      this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OkBtn.Location = new System.Drawing.Point(101, 59);
      this.OkBtn.Name = "OkBtn";
      this.OkBtn.Size = new System.Drawing.Size(54, 23);
      this.OkBtn.TabIndex = 3;
      this.OkBtn.Text = "Ок";
      this.OkBtn.UseVisualStyleBackColor = true;
      // 
      // CancelBtn
      // 
      this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelBtn.Location = new System.Drawing.Point(161, 59);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(54, 23);
      this.CancelBtn.TabIndex = 4;
      this.CancelBtn.Text = "Отмена";
      this.CancelBtn.UseVisualStyleBackColor = true;
      // 
      // EffectDialog
      // 
      this.AcceptButton = this.OkBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CancelBtn;
      this.ClientSize = new System.Drawing.Size(218, 86);
      this.Controls.Add(this.TableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EffectDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Создать эффект";
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      this.TypePanel.ResumeLayout(false);
      this.TypePanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.TextBox EffectName;
    private BugFix.MyNumericInput RemainTime;
    private System.Windows.Forms.FlowLayoutPanel TypePanel;
    private System.Windows.Forms.RadioButton IsDebuff;
    private System.Windows.Forms.RadioButton IsBuff;
    private System.Windows.Forms.Button OkBtn;
    private System.Windows.Forms.Button CancelBtn;
  }
}