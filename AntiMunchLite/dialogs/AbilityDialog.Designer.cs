using AntiMunchLite.BaseControls;

namespace AntiMunchLite.Dialogs
{
  partial class AbilityDialog
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.CancelBtn = new System.Windows.Forms.Button();
      this.Combotants = new System.Windows.Forms.CheckedListBox();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.NameCB = new System.Windows.Forms.ComboBox();
      this.RemainNum = new AntiMunchLite.BaseControls.CustomNumericInput();
      this.label1 = new System.Windows.Forms.Label();
      this.TotalNum = new AntiMunchLite.BaseControls.CustomNumericInput();
      this.OkBtn = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.tableLayoutPanel1.Controls.Add(this.CancelBtn, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.Combotants, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.OkBtn, 1, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 262);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // CancelBtn
      // 
      this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CancelBtn.Location = new System.Drawing.Point(277, 238);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(64, 21);
      this.CancelBtn.TabIndex = 5;
      this.CancelBtn.Text = "Cancel";
      this.CancelBtn.UseVisualStyleBackColor = true;
      // 
      // Combotants
      // 
      this.Combotants.CheckOnClick = true;
      this.tableLayoutPanel1.SetColumnSpan(this.Combotants, 3);
      this.Combotants.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Combotants.FormattingEnabled = true;
      this.Combotants.Location = new System.Drawing.Point(3, 3);
      this.Combotants.Name = "Combotants";
      this.Combotants.Size = new System.Drawing.Size(338, 201);
      this.Combotants.TabIndex = 6;
      // 
      // flowLayoutPanel1
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 3);
      this.flowLayoutPanel1.Controls.Add(this.NameCB);
      this.flowLayoutPanel1.Controls.Add(this.RemainNum);
      this.flowLayoutPanel1.Controls.Add(this.label1);
      this.flowLayoutPanel1.Controls.Add(this.TotalNum);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 207);
      this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(344, 28);
      this.flowLayoutPanel1.TabIndex = 8;
      // 
      // NameCB
      // 
      this.NameCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.NameCB.FormattingEnabled = true;
      this.NameCB.Location = new System.Drawing.Point(3, 3);
      this.NameCB.Name = "NameCB";
      this.NameCB.Size = new System.Drawing.Size(240, 21);
      this.NameCB.TabIndex = 7;
      // 
      // RemainNum
      // 
      this.RemainNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.RemainNum.Location = new System.Drawing.Point(249, 3);
      this.RemainNum.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
      this.RemainNum.Maximum = null;
      this.RemainNum.Minimum = null;
      this.RemainNum.Name = "RemainNum";
      this.RemainNum.Size = new System.Drawing.Size(33, 20);
      this.RemainNum.TabIndex = 8;
      this.RemainNum.Text = "3";
      this.RemainNum.ToolTip = null;
      this.RemainNum.Value = 3;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(283, 7);
      this.label1.Margin = new System.Windows.Forms.Padding(0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(12, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "/";
      // 
      // TotalNum
      // 
      this.TotalNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.TotalNum.Location = new System.Drawing.Point(296, 3);
      this.TotalNum.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
      this.TotalNum.Maximum = null;
      this.TotalNum.Minimum = 0;
      this.TotalNum.Name = "TotalNum";
      this.TotalNum.Size = new System.Drawing.Size(33, 20);
      this.TotalNum.TabIndex = 10;
      this.TotalNum.Text = "3";
      this.TotalNum.ToolTip = null;
      this.TotalNum.Value = 3;
      // 
      // OkBtn
      // 
      this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.OkBtn.Location = new System.Drawing.Point(207, 238);
      this.OkBtn.Name = "OkBtn";
      this.OkBtn.Size = new System.Drawing.Size(64, 21);
      this.OkBtn.TabIndex = 4;
      this.OkBtn.Text = "OK";
      this.OkBtn.UseVisualStyleBackColor = true;
      // 
      // AbilityDialog
      // 
      this.AcceptButton = this.OkBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CancelBtn;
      this.ClientSize = new System.Drawing.Size(344, 262);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AbilityDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Create Ability";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button OkBtn;
    private System.Windows.Forms.Button CancelBtn;
    private System.Windows.Forms.CheckedListBox Combotants;
    private System.Windows.Forms.ComboBox NameCB;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private CustomNumericInput RemainNum;
    private System.Windows.Forms.Label label1;
    private CustomNumericInput TotalNum;
  }
}