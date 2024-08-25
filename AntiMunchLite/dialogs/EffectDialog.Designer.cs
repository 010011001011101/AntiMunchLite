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
      TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      OkBtn = new System.Windows.Forms.Button();
      CancelBtn = new System.Windows.Forms.Button();
      EffectName = new System.Windows.Forms.ComboBox();
      Combotants = new System.Windows.Forms.CheckedListBox();
      TypePanel = new System.Windows.Forms.FlowLayoutPanel();
      IsDebuff = new System.Windows.Forms.RadioButton();
      IsBuff = new System.Windows.Forms.RadioButton();
      RemainTime = new CustomNumericInput();
      TimeFlow = new System.Windows.Forms.FlowLayoutPanel();
      RoundTime = new System.Windows.Forms.RadioButton();
      MinuteTime = new System.Windows.Forms.RadioButton();
      TenMinutesTime = new System.Windows.Forms.RadioButton();
      HourTime = new System.Windows.Forms.RadioButton();
      TableLayoutPanel.SuspendLayout();
      TypePanel.SuspendLayout();
      TimeFlow.SuspendLayout();
      SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      TableLayoutPanel.ColumnCount = 4;
      TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
      TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
      TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
      TableLayoutPanel.Controls.Add(OkBtn, 2, 3);
      TableLayoutPanel.Controls.Add(CancelBtn, 3, 3);
      TableLayoutPanel.Controls.Add(EffectName, 0, 1);
      TableLayoutPanel.Controls.Add(Combotants, 0, 0);
      TableLayoutPanel.Controls.Add(TypePanel, 2, 1);
      TableLayoutPanel.Controls.Add(RemainTime, 0, 2);
      TableLayoutPanel.Controls.Add(TimeFlow, 1, 2);
      TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      TableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      TableLayoutPanel.Name = "TableLayoutPanel";
      TableLayoutPanel.RowCount = 4;
      TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
      TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
      TableLayoutPanel.Size = new System.Drawing.Size(401, 302);
      TableLayoutPanel.TabIndex = 0;
      // 
      // OkBtn
      // 
      OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      OkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      OkBtn.Location = new System.Drawing.Point(241, 274);
      OkBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      OkBtn.Name = "OkBtn";
      OkBtn.Size = new System.Drawing.Size(74, 25);
      OkBtn.TabIndex = 3;
      OkBtn.Text = "OK";
      OkBtn.UseVisualStyleBackColor = true;
      // 
      // CancelBtn
      // 
      CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      CancelBtn.Location = new System.Drawing.Point(323, 274);
      CancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      CancelBtn.Name = "CancelBtn";
      CancelBtn.Size = new System.Drawing.Size(74, 25);
      CancelBtn.TabIndex = 4;
      CancelBtn.Text = "Cancel";
      CancelBtn.UseVisualStyleBackColor = true;
      // 
      // EffectName
      // 
      EffectName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      EffectName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      TableLayoutPanel.SetColumnSpan(EffectName, 2);
      EffectName.Dock = System.Windows.Forms.DockStyle.Top;
      EffectName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
      EffectName.FormattingEnabled = true;
      EffectName.Location = new System.Drawing.Point(4, 213);
      EffectName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      EffectName.Name = "EffectName";
      EffectName.Size = new System.Drawing.Size(229, 22);
      EffectName.TabIndex = 0;
      // 
      // Combotants
      // 
      Combotants.CheckOnClick = true;
      TableLayoutPanel.SetColumnSpan(Combotants, 4);
      Combotants.Dock = System.Windows.Forms.DockStyle.Fill;
      Combotants.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
      Combotants.FormattingEnabled = true;
      Combotants.Location = new System.Drawing.Point(4, 3);
      Combotants.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      Combotants.Name = "Combotants";
      Combotants.Size = new System.Drawing.Size(393, 204);
      Combotants.TabIndex = 5;
      Combotants.TabStop = false;
      // 
      // TypePanel
      // 
      TableLayoutPanel.SetColumnSpan(TypePanel, 2);
      TypePanel.Controls.Add(IsDebuff);
      TypePanel.Controls.Add(IsBuff);
      TypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
      TypePanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      TypePanel.Location = new System.Drawing.Point(237, 210);
      TypePanel.Margin = new System.Windows.Forms.Padding(0);
      TypePanel.Name = "TypePanel";
      TypePanel.Size = new System.Drawing.Size(164, 31);
      TypePanel.TabIndex = 1;
      // 
      // IsDebuff
      // 
      IsDebuff.AutoSize = true;
      IsDebuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
      IsDebuff.ForeColor = System.Drawing.Color.DarkRed;
      IsDebuff.Location = new System.Drawing.Point(97, 3);
      IsDebuff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      IsDebuff.Name = "IsDebuff";
      IsDebuff.Size = new System.Drawing.Size(63, 17);
      IsDebuff.TabIndex = 1;
      IsDebuff.Text = "Debuff";
      IsDebuff.UseVisualStyleBackColor = true;
      // 
      // IsBuff
      // 
      IsBuff.AutoSize = true;
      IsBuff.Checked = true;
      IsBuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
      IsBuff.ForeColor = System.Drawing.Color.Green;
      IsBuff.Location = new System.Drawing.Point(41, 3);
      IsBuff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      IsBuff.Name = "IsBuff";
      IsBuff.Size = new System.Drawing.Size(48, 17);
      IsBuff.TabIndex = 0;
      IsBuff.TabStop = true;
      IsBuff.Text = "Buff";
      IsBuff.UseVisualStyleBackColor = true;
      // 
      // RemainTime
      // 
      RemainTime.Dock = System.Windows.Forms.DockStyle.Fill;
      RemainTime.Location = new System.Drawing.Point(4, 244);
      RemainTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      RemainTime.Maximum = null;
      RemainTime.Minimum = null;
      RemainTime.Name = "RemainTime";
      RemainTime.Size = new System.Drawing.Size(48, 23);
      RemainTime.TabIndex = 2;
      RemainTime.Text = "1";
      RemainTime.ToolTip = null;
      RemainTime.Value = 1;
      // 
      // TimeFlow
      // 
      TableLayoutPanel.SetColumnSpan(TimeFlow, 3);
      TimeFlow.Controls.Add(RoundTime);
      TimeFlow.Controls.Add(MinuteTime);
      TimeFlow.Controls.Add(TenMinutesTime);
      TimeFlow.Controls.Add(HourTime);
      TimeFlow.Dock = System.Windows.Forms.DockStyle.Fill;
      TimeFlow.Location = new System.Drawing.Point(56, 241);
      TimeFlow.Margin = new System.Windows.Forms.Padding(0);
      TimeFlow.Name = "TimeFlow";
      TimeFlow.Size = new System.Drawing.Size(345, 30);
      TimeFlow.TabIndex = 5;
      // 
      // RoundTime
      // 
      RoundTime.AutoSize = true;
      RoundTime.Checked = true;
      RoundTime.Location = new System.Drawing.Point(4, 3);
      RoundTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      RoundTime.Name = "RoundTime";
      RoundTime.Size = new System.Drawing.Size(69, 19);
      RoundTime.TabIndex = 0;
      RoundTime.TabStop = true;
      RoundTime.Text = "1 Round";
      RoundTime.UseVisualStyleBackColor = true;
      // 
      // MinuteTime
      // 
      MinuteTime.AutoSize = true;
      MinuteTime.Location = new System.Drawing.Point(81, 3);
      MinuteTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      MinuteTime.Name = "MinuteTime";
      MinuteTime.Size = new System.Drawing.Size(72, 19);
      MinuteTime.TabIndex = 1;
      MinuteTime.Text = "1 Minute";
      MinuteTime.UseVisualStyleBackColor = true;
      // 
      // TenMinutesTime
      // 
      TenMinutesTime.AutoSize = true;
      TenMinutesTime.Location = new System.Drawing.Point(161, 3);
      TenMinutesTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      TenMinutesTime.Name = "TenMinutesTime";
      TenMinutesTime.Size = new System.Drawing.Size(83, 19);
      TenMinutesTime.TabIndex = 2;
      TenMinutesTime.Text = "10 Minutes";
      TenMinutesTime.UseVisualStyleBackColor = true;
      // 
      // HourTime
      // 
      HourTime.AutoSize = true;
      HourTime.Location = new System.Drawing.Point(252, 3);
      HourTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      HourTime.Name = "HourTime";
      HourTime.Size = new System.Drawing.Size(61, 19);
      HourTime.TabIndex = 3;
      HourTime.Text = "1 Hour";
      HourTime.UseVisualStyleBackColor = true;
      // 
      // EffectDialog
      // 
      AcceptButton = OkBtn;
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      CancelButton = CancelBtn;
      ClientSize = new System.Drawing.Size(401, 302);
      Controls.Add(TableLayoutPanel);
      FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "EffectDialog";
      ShowIcon = false;
      ShowInTaskbar = false;
      StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      Text = "Create Effect";
      TableLayoutPanel.ResumeLayout(false);
      TableLayoutPanel.PerformLayout();
      TypePanel.ResumeLayout(false);
      TypePanel.PerformLayout();
      TimeFlow.ResumeLayout(false);
      TimeFlow.PerformLayout();
      ResumeLayout(false);
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