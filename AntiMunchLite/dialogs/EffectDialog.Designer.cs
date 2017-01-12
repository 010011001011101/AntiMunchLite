namespace AntiMunchLite
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
      this.RemainTime = new AntiMunchLite.BugFix.MyNumericInput();
      this.TypePanel = new System.Windows.Forms.FlowLayoutPanel();
      this.IsDebuff = new System.Windows.Forms.RadioButton();
      this.IsBuff = new System.Windows.Forms.RadioButton();
      this.OkBtn = new System.Windows.Forms.Button();
      this.CancelBtn = new System.Windows.Forms.Button();
      this.EffectName = new System.Windows.Forms.ComboBox();
      this.Combotants = new System.Windows.Forms.CheckedListBox();
      this.TableLayoutPanel.SuspendLayout();
      this.TypePanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 2;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.TableLayoutPanel.Controls.Add(this.RemainTime, 1, 2);
      this.TableLayoutPanel.Controls.Add(this.TypePanel, 0, 2);
      this.TableLayoutPanel.Controls.Add(this.OkBtn, 0, 3);
      this.TableLayoutPanel.Controls.Add(this.CancelBtn, 1, 3);
      this.TableLayoutPanel.Controls.Add(this.EffectName, 0, 1);
      this.TableLayoutPanel.Controls.Add(this.Combotants, 0, 0);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 4;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(277, 300);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // RemainTime
      // 
      this.RemainTime.Dock = System.Windows.Forms.DockStyle.Top;
      this.RemainTime.Location = new System.Drawing.Point(201, 233);
      this.RemainTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.RemainTime.Maximum = new decimal(new int[] {
            900,
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
      this.RemainTime.Size = new System.Drawing.Size(72, 22);
      this.RemainTime.TabIndex = 2;
      this.RemainTime.Text = "10";
      this.RemainTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // TypePanel
      // 
      this.TypePanel.Controls.Add(this.IsDebuff);
      this.TypePanel.Controls.Add(this.IsBuff);
      this.TypePanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.TypePanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.TypePanel.Location = new System.Drawing.Point(4, 233);
      this.TypePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.TypePanel.Name = "TypePanel";
      this.TypePanel.Size = new System.Drawing.Size(189, 26);
      this.TypePanel.TabIndex = 1;
      // 
      // IsDebuff
      // 
      this.IsDebuff.AutoSize = true;
      this.IsDebuff.Location = new System.Drawing.Point(99, 4);
      this.IsDebuff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.IsDebuff.Name = "IsDebuff";
      this.IsDebuff.Size = new System.Drawing.Size(86, 21);
      this.IsDebuff.TabIndex = 1;
      this.IsDebuff.Text = "Дебафф";
      this.IsDebuff.UseVisualStyleBackColor = true;
      // 
      // IsBuff
      // 
      this.IsBuff.AutoSize = true;
      this.IsBuff.Checked = true;
      this.IsBuff.Location = new System.Drawing.Point(23, 4);
      this.IsBuff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.IsBuff.Name = "IsBuff";
      this.IsBuff.Size = new System.Drawing.Size(68, 21);
      this.IsBuff.TabIndex = 0;
      this.IsBuff.TabStop = true;
      this.IsBuff.Text = "Бафф";
      this.IsBuff.UseVisualStyleBackColor = true;
      // 
      // OkBtn
      // 
      this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OkBtn.Location = new System.Drawing.Point(121, 267);
      this.OkBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.OkBtn.Name = "OkBtn";
      this.OkBtn.Size = new System.Drawing.Size(72, 28);
      this.OkBtn.TabIndex = 3;
      this.OkBtn.Text = "Ок";
      this.OkBtn.UseVisualStyleBackColor = true;
      // 
      // CancelBtn
      // 
      this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelBtn.Location = new System.Drawing.Point(201, 267);
      this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(72, 28);
      this.CancelBtn.TabIndex = 4;
      this.CancelBtn.Text = "Отмена";
      this.CancelBtn.UseVisualStyleBackColor = true;
      // 
      // EffectName
      // 
      this.EffectName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.EffectName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.TableLayoutPanel.SetColumnSpan(this.EffectName, 2);
      this.EffectName.Dock = System.Windows.Forms.DockStyle.Top;
      this.EffectName.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.EffectName.FormattingEnabled = true;
      this.EffectName.Location = new System.Drawing.Point(4, 200);
      this.EffectName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.EffectName.Name = "EffectName";
      this.EffectName.Size = new System.Drawing.Size(269, 24);
      this.EffectName.TabIndex = 0;
      // 
      // Combotants
      // 
      this.Combotants.CheckOnClick = true;
      this.TableLayoutPanel.SetColumnSpan(this.Combotants, 2);
      this.Combotants.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Combotants.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Combotants.FormattingEnabled = true;
      this.Combotants.Location = new System.Drawing.Point(4, 4);
      this.Combotants.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Combotants.Name = "Combotants";
      this.Combotants.Size = new System.Drawing.Size(269, 188);
      this.Combotants.TabIndex = 4;
      this.Combotants.TabStop = false;
      // 
      // EffectDialog
      // 
      this.AcceptButton = this.OkBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CancelBtn;
      this.ClientSize = new System.Drawing.Size(277, 300);
      this.Controls.Add(this.TableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    private BugFix.MyNumericInput RemainTime;
    private System.Windows.Forms.FlowLayoutPanel TypePanel;
    private System.Windows.Forms.RadioButton IsDebuff;
    private System.Windows.Forms.RadioButton IsBuff;
    private System.Windows.Forms.Button OkBtn;
    private System.Windows.Forms.Button CancelBtn;
    private System.Windows.Forms.ComboBox EffectName;
    private System.Windows.Forms.CheckedListBox Combotants;
  }
}