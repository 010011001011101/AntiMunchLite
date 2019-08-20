using AntiMunchLite.BaseControls;

namespace AntiMunchLite.Dialogs
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
      this.OkBtn = new System.Windows.Forms.Button();
      this.CancelBtn = new System.Windows.Forms.Button();
      this.EffectName = new System.Windows.Forms.ComboBox();
      this.Combotants = new System.Windows.Forms.CheckedListBox();
      this.TypePanel = new System.Windows.Forms.FlowLayoutPanel();
      this.IsDebuff = new System.Windows.Forms.RadioButton();
      this.IsBuff = new System.Windows.Forms.RadioButton();
      this.RemainTime = new AntiMunchLite.BaseControls.CustomNumericInput();
      this.TimeFlow = new System.Windows.Forms.FlowLayoutPanel();
      this.RoundTime = new System.Windows.Forms.RadioButton();
      this.MinuteTime = new System.Windows.Forms.RadioButton();
      this.TenMinutesTime = new System.Windows.Forms.RadioButton();
      this.HourTime = new System.Windows.Forms.RadioButton();
      this.TableLayoutPanel.SuspendLayout();
      this.TypePanel.SuspendLayout();
      this.TimeFlow.SuspendLayout();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 4;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.TableLayoutPanel.Controls.Add(this.OkBtn, 2, 3);
      this.TableLayoutPanel.Controls.Add(this.CancelBtn, 3, 3);
      this.TableLayoutPanel.Controls.Add(this.EffectName, 0, 1);
      this.TableLayoutPanel.Controls.Add(this.Combotants, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.TypePanel, 2, 1);
      this.TableLayoutPanel.Controls.Add(this.RemainTime, 0, 2);
      this.TableLayoutPanel.Controls.Add(this.TimeFlow, 1, 2);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 4;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(344, 262);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // OkBtn
      // 
      this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.OkBtn.Location = new System.Drawing.Point(207, 238);
      this.OkBtn.Name = "OkBtn";
      this.OkBtn.Size = new System.Drawing.Size(64, 21);
      this.OkBtn.TabIndex = 3;
      this.OkBtn.Text = "OK";
      this.OkBtn.UseVisualStyleBackColor = true;
      // 
      // CancelBtn
      // 
      this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CancelBtn.Location = new System.Drawing.Point(277, 238);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(64, 21);
      this.CancelBtn.TabIndex = 4;
      this.CancelBtn.Text = "Cancel";
      this.CancelBtn.UseVisualStyleBackColor = true;
      // 
      // EffectName
      // 
      this.EffectName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.EffectName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.TableLayoutPanel.SetColumnSpan(this.EffectName, 2);
      this.EffectName.Dock = System.Windows.Forms.DockStyle.Top;
      this.EffectName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.EffectName.FormattingEnabled = true;
      this.EffectName.Location = new System.Drawing.Point(3, 185);
      this.EffectName.Name = "EffectName";
      this.EffectName.Size = new System.Drawing.Size(198, 22);
      this.EffectName.TabIndex = 0;
      // 
      // Combotants
      // 
      this.Combotants.CheckOnClick = true;
      this.TableLayoutPanel.SetColumnSpan(this.Combotants, 4);
      this.Combotants.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Combotants.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Combotants.FormattingEnabled = true;
      this.Combotants.Location = new System.Drawing.Point(3, 3);
      this.Combotants.Name = "Combotants";
      this.Combotants.Size = new System.Drawing.Size(338, 176);
      this.Combotants.TabIndex = 5;
      this.Combotants.TabStop = false;
      // 
      // TypePanel
      // 
      this.TableLayoutPanel.SetColumnSpan(this.TypePanel, 2);
      this.TypePanel.Controls.Add(this.IsDebuff);
      this.TypePanel.Controls.Add(this.IsBuff);
      this.TypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TypePanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.TypePanel.Location = new System.Drawing.Point(204, 182);
      this.TypePanel.Margin = new System.Windows.Forms.Padding(0);
      this.TypePanel.Name = "TypePanel";
      this.TypePanel.Size = new System.Drawing.Size(140, 27);
      this.TypePanel.TabIndex = 1;
      // 
      // IsDebuff
      // 
      this.IsDebuff.AutoSize = true;
      this.IsDebuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.IsDebuff.ForeColor = System.Drawing.Color.DarkRed;
      this.IsDebuff.Location = new System.Drawing.Point(74, 3);
      this.IsDebuff.Name = "IsDebuff";
      this.IsDebuff.Size = new System.Drawing.Size(63, 17);
      this.IsDebuff.TabIndex = 1;
      this.IsDebuff.Text = "Debuff";
      this.IsDebuff.UseVisualStyleBackColor = true;
      // 
      // IsBuff
      // 
      this.IsBuff.AutoSize = true;
      this.IsBuff.Checked = true;
      this.IsBuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.IsBuff.ForeColor = System.Drawing.Color.Green;
      this.IsBuff.Location = new System.Drawing.Point(20, 3);
      this.IsBuff.Name = "IsBuff";
      this.IsBuff.Size = new System.Drawing.Size(48, 17);
      this.IsBuff.TabIndex = 0;
      this.IsBuff.TabStop = true;
      this.IsBuff.Text = "Buff";
      this.IsBuff.UseVisualStyleBackColor = true;
      // 
      // RemainTime
      // 
      this.RemainTime.Dock = System.Windows.Forms.DockStyle.Fill;
      this.RemainTime.Location = new System.Drawing.Point(3, 212);
      this.RemainTime.Maximum = null;
      this.RemainTime.Minimum = null;
      this.RemainTime.Name = "RemainTime";
      this.RemainTime.Size = new System.Drawing.Size(42, 20);
      this.RemainTime.TabIndex = 2;
      this.RemainTime.Text = "1";
      this.RemainTime.ToolTip = null;
      this.RemainTime.Value = 1;
      // 
      // TimeFlow
      // 
      this.TableLayoutPanel.SetColumnSpan(this.TimeFlow, 3);
      this.TimeFlow.Controls.Add(this.RoundTime);
      this.TimeFlow.Controls.Add(this.MinuteTime);
      this.TimeFlow.Controls.Add(this.TenMinutesTime);
      this.TimeFlow.Controls.Add(this.HourTime);
      this.TimeFlow.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TimeFlow.Location = new System.Drawing.Point(48, 209);
      this.TimeFlow.Margin = new System.Windows.Forms.Padding(0);
      this.TimeFlow.Name = "TimeFlow";
      this.TimeFlow.Size = new System.Drawing.Size(296, 26);
      this.TimeFlow.TabIndex = 5;
      // 
      // RoundTime
      // 
      this.RoundTime.AutoSize = true;
      this.RoundTime.Checked = true;
      this.RoundTime.Location = new System.Drawing.Point(3, 3);
      this.RoundTime.Name = "RoundTime";
      this.RoundTime.Size = new System.Drawing.Size(66, 17);
      this.RoundTime.TabIndex = 0;
      this.RoundTime.TabStop = true;
      this.RoundTime.Text = "1 Round";
      this.RoundTime.UseVisualStyleBackColor = true;
      // 
      // MinuteTime
      // 
      this.MinuteTime.AutoSize = true;
      this.MinuteTime.Location = new System.Drawing.Point(75, 3);
      this.MinuteTime.Name = "MinuteTime";
      this.MinuteTime.Size = new System.Drawing.Size(66, 17);
      this.MinuteTime.TabIndex = 1;
      this.MinuteTime.Text = "1 Minute";
      this.MinuteTime.UseVisualStyleBackColor = true;
      // 
      // TenMinutesTime
      // 
      this.TenMinutesTime.AutoSize = true;
      this.TenMinutesTime.Location = new System.Drawing.Point(147, 3);
      this.TenMinutesTime.Name = "TenMinutesTime";
      this.TenMinutesTime.Size = new System.Drawing.Size(77, 17);
      this.TenMinutesTime.TabIndex = 2;
      this.TenMinutesTime.Text = "10 Minutes";
      this.TenMinutesTime.UseVisualStyleBackColor = true;
      // 
      // HourTime
      // 
      this.HourTime.AutoSize = true;
      this.HourTime.Location = new System.Drawing.Point(230, 3);
      this.HourTime.Name = "HourTime";
      this.HourTime.Size = new System.Drawing.Size(57, 17);
      this.HourTime.TabIndex = 3;
      this.HourTime.Text = "1 Hour";
      this.HourTime.UseVisualStyleBackColor = true;
      // 
      // EffectDialog
      // 
      this.AcceptButton = this.OkBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CancelBtn;
      this.ClientSize = new System.Drawing.Size(344, 262);
      this.Controls.Add(this.TableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EffectDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Create Effect";
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      this.TypePanel.ResumeLayout(false);
      this.TypePanel.PerformLayout();
      this.TimeFlow.ResumeLayout(false);
      this.TimeFlow.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private CustomNumericInput RemainTime;
    private System.Windows.Forms.FlowLayoutPanel TypePanel;
    private System.Windows.Forms.RadioButton IsDebuff;
    private System.Windows.Forms.RadioButton IsBuff;
    private System.Windows.Forms.Button OkBtn;
    private System.Windows.Forms.Button CancelBtn;
    private System.Windows.Forms.ComboBox EffectName;
    private System.Windows.Forms.CheckedListBox Combotants;
    private System.Windows.Forms.FlowLayoutPanel TimeFlow;
    private System.Windows.Forms.RadioButton RoundTime;
    private System.Windows.Forms.RadioButton MinuteTime;
    private System.Windows.Forms.RadioButton TenMinutesTime;
    private System.Windows.Forms.RadioButton HourTime;
  }
}