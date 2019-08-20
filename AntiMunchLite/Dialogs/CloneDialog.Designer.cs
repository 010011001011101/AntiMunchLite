using AntiMunchLite.BaseControls;

namespace AntiMunchLite.Dialogs
{
  partial class CloneDialog
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
      this.OkBtn = new System.Windows.Forms.Button();
      this.DropInitiativeCB = new System.Windows.Forms.CheckBox();
      this.DropHPCB = new System.Windows.Forms.CheckBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.tableLayoutPanel1.Controls.Add(this.CancelBtn, 2, 3);
      this.tableLayoutPanel1.Controls.Add(this.Combotants, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.OkBtn, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.DropInitiativeCB, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.DropHPCB, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 262);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // CancelBtn
      // 
      this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CancelBtn.Location = new System.Drawing.Point(217, 238);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(64, 21);
      this.CancelBtn.TabIndex = 4;
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
      this.Combotants.Size = new System.Drawing.Size(278, 175);
      this.Combotants.TabIndex = 0;
      // 
      // OkBtn
      // 
      this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.OkBtn.Location = new System.Drawing.Point(147, 238);
      this.OkBtn.Name = "OkBtn";
      this.OkBtn.Size = new System.Drawing.Size(64, 21);
      this.OkBtn.TabIndex = 3;
      this.OkBtn.Text = "OK";
      this.OkBtn.UseVisualStyleBackColor = true;
      // 
      // DropInitiativeCB
      // 
      this.DropInitiativeCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.DropInitiativeCB.AutoSize = true;
      this.tableLayoutPanel1.SetColumnSpan(this.DropInitiativeCB, 3);
      this.DropInitiativeCB.Location = new System.Drawing.Point(3, 186);
      this.DropInitiativeCB.Name = "DropInitiativeCB";
      this.DropInitiativeCB.Size = new System.Drawing.Size(91, 17);
      this.DropInitiativeCB.TabIndex = 1;
      this.DropInitiativeCB.Text = "Drop Initiative";
      this.DropInitiativeCB.UseVisualStyleBackColor = true;
      // 
      // DropHPCB
      // 
      this.DropHPCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.DropHPCB.AutoSize = true;
      this.tableLayoutPanel1.SetColumnSpan(this.DropHPCB, 3);
      this.DropHPCB.Location = new System.Drawing.Point(3, 213);
      this.DropHPCB.Name = "DropHPCB";
      this.DropHPCB.Size = new System.Drawing.Size(67, 17);
      this.DropHPCB.TabIndex = 2;
      this.DropHPCB.Text = "Drop HP";
      this.DropHPCB.UseVisualStyleBackColor = true;
      // 
      // CloneDialog
      // 
      this.AcceptButton = this.OkBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CancelBtn;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CloneDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Clone Combatant(s)";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button OkBtn;
    private System.Windows.Forms.Button CancelBtn;
    private System.Windows.Forms.CheckedListBox Combotants;
    private System.Windows.Forms.CheckBox DropInitiativeCB;
    private System.Windows.Forms.CheckBox DropHPCB;
  }
}