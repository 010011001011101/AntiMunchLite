namespace AntiMunchLite.Dialogs
{
  partial class DmgDialogCombatantItem
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      NameCB = new System.Windows.Forms.CheckBox();
      HalfR = new System.Windows.Forms.RadioButton();
      NormalR = new System.Windows.Forms.RadioButton();
      DoubleR = new System.Windows.Forms.RadioButton();
      tableLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 4;
      tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      tableLayoutPanel1.Controls.Add(NameCB, 0, 0);
      tableLayoutPanel1.Controls.Add(HalfR, 1, 0);
      tableLayoutPanel1.Controls.Add(NormalR, 2, 0);
      tableLayoutPanel1.Controls.Add(DoubleR, 3, 0);
      tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      tableLayoutPanel1.Size = new System.Drawing.Size(278, 24);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // NameCB
      // 
      NameCB.Dock = System.Windows.Forms.DockStyle.Fill;
      NameCB.Location = new System.Drawing.Point(3, 3);
      NameCB.Name = "NameCB";
      NameCB.Size = new System.Drawing.Size(182, 19);
      NameCB.TabIndex = 0;
      NameCB.Text = "<Combatant Name>";
      NameCB.UseVisualStyleBackColor = true;
      NameCB.CheckedChanged += NameCB_CheckedChanged;
      // 
      // HalfR
      // 
      HalfR.Anchor = System.Windows.Forms.AnchorStyles.None;
      HalfR.AutoSize = true;
      HalfR.Location = new System.Drawing.Point(196, 6);
      HalfR.Name = "HalfR";
      HalfR.Size = new System.Drawing.Size(14, 13);
      HalfR.TabIndex = 1;
      HalfR.TabStop = true;
      HalfR.UseVisualStyleBackColor = true;
      // 
      // NormalR
      // 
      NormalR.Anchor = System.Windows.Forms.AnchorStyles.None;
      NormalR.AutoSize = true;
      NormalR.Checked = true;
      NormalR.Location = new System.Drawing.Point(226, 6);
      NormalR.Name = "NormalR";
      NormalR.Size = new System.Drawing.Size(14, 13);
      NormalR.TabIndex = 2;
      NormalR.TabStop = true;
      NormalR.UseVisualStyleBackColor = true;
      // 
      // DoubleR
      // 
      DoubleR.Anchor = System.Windows.Forms.AnchorStyles.None;
      DoubleR.AutoSize = true;
      DoubleR.Location = new System.Drawing.Point(256, 6);
      DoubleR.Name = "DoubleR";
      DoubleR.Size = new System.Drawing.Size(14, 13);
      DoubleR.TabIndex = 3;
      DoubleR.TabStop = true;
      DoubleR.UseVisualStyleBackColor = true;
      // 
      // DmgDialogCombatantItem
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      BackColor = System.Drawing.Color.White;
      BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      Controls.Add(tableLayoutPanel1);
      Name = "DmgDialogCombatantItem";
      Size = new System.Drawing.Size(278, 24);
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel1.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.CheckBox NameCB;
    private System.Windows.Forms.RadioButton HalfR;
    private System.Windows.Forms.RadioButton NormalR;
    private System.Windows.Forms.RadioButton DoubleR;
  }
}
