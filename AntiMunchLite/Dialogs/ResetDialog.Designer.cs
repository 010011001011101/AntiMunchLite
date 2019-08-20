namespace AntiMunchLite.Dialogs
{
  partial class ResetDialog
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
      this.components = new System.ComponentModel.Container();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.OkBtn = new System.Windows.Forms.Button();
      this.CancelBtn = new System.Windows.Forms.Button();
      this.DropInitiativeCB = new System.Windows.Forms.CheckBox();
      this.DropEffectsCB = new System.Windows.Forms.CheckBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
      this.tableLayoutPanel1.Controls.Add(this.OkBtn, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.DropInitiativeCB, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.DropEffectsCB, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(205, 83);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // OkBtn
      // 
      this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.OkBtn.Location = new System.Drawing.Point(68, 59);
      this.OkBtn.Name = "OkBtn";
      this.OkBtn.Size = new System.Drawing.Size(64, 21);
      this.OkBtn.TabIndex = 2;
      this.OkBtn.Text = "OK";
      this.OkBtn.UseVisualStyleBackColor = true;
      // 
      // CancelBtn
      // 
      this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CancelBtn.Location = new System.Drawing.Point(138, 59);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(64, 21);
      this.CancelBtn.TabIndex = 3;
      this.CancelBtn.Text = "Cancel";
      this.CancelBtn.UseVisualStyleBackColor = true;
      // 
      // DropInitiativeCB
      // 
      this.DropInitiativeCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.DropInitiativeCB.AutoSize = true;
      this.DropInitiativeCB.Checked = true;
      this.DropInitiativeCB.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tableLayoutPanel1.SetColumnSpan(this.DropInitiativeCB, 3);
      this.DropInitiativeCB.Location = new System.Drawing.Point(3, 5);
      this.DropInitiativeCB.Name = "DropInitiativeCB";
      this.DropInitiativeCB.Size = new System.Drawing.Size(91, 17);
      this.DropInitiativeCB.TabIndex = 0;
      this.DropInitiativeCB.Text = "Drop Initiative";
      this.toolTip1.SetToolTip(this.DropInitiativeCB, "Drop all combatants initiative to 0");
      this.DropInitiativeCB.UseVisualStyleBackColor = true;
      // 
      // DropEffectsCB
      // 
      this.DropEffectsCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.DropEffectsCB.AutoSize = true;
      this.DropEffectsCB.Checked = true;
      this.DropEffectsCB.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tableLayoutPanel1.SetColumnSpan(this.DropEffectsCB, 3);
      this.DropEffectsCB.Location = new System.Drawing.Point(3, 32);
      this.DropEffectsCB.Name = "DropEffectsCB";
      this.DropEffectsCB.Size = new System.Drawing.Size(85, 17);
      this.DropEffectsCB.TabIndex = 1;
      this.DropEffectsCB.Text = "Drop Effects";
      this.toolTip1.SetToolTip(this.DropEffectsCB, "Delete all effects from all combatants");
      this.DropEffectsCB.UseVisualStyleBackColor = true;
      // 
      // ResetDialog
      // 
      this.AcceptButton = this.OkBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CancelBtn;
      this.ClientSize = new System.Drawing.Size(205, 83);
      this.Controls.Add(this.tableLayoutPanel1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ResetDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Reset Encounter";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button OkBtn;
    private System.Windows.Forms.Button CancelBtn;
    private System.Windows.Forms.CheckBox DropInitiativeCB;
    private System.Windows.Forms.CheckBox DropEffectsCB;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}