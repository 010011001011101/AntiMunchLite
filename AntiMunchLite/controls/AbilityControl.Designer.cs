using AntiMunchLite.BaseControls;

namespace AntiMunchLite.Controls
{
  partial class AbilityControl
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.DelBtn = new System.Windows.Forms.Button();
      this.AbilityNameTB = new System.Windows.Forms.TextBox();
      this.RemainNum = new CustomNumericInput();
      this.SpendOneBtn = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.TotalNum = new CustomNumericInput();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 6;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.tableLayoutPanel1.Controls.Add(this.DelBtn, 5, 0);
      this.tableLayoutPanel1.Controls.Add(this.AbilityNameTB, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.RemainNum, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.SpendOneBtn, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.TotalNum, 4, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(248, 24);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // DelBtn
      // 
      this.DelBtn.Dock = System.Windows.Forms.DockStyle.Left;
      this.DelBtn.Location = new System.Drawing.Point(233, 0);
      this.DelBtn.Margin = new System.Windows.Forms.Padding(0);
      this.DelBtn.Name = "DelBtn";
      this.DelBtn.Size = new System.Drawing.Size(15, 24);
      this.DelBtn.TabIndex = 4;
      this.DelBtn.TabStop = false;
      this.DelBtn.Text = "X";
      this.DelBtn.UseVisualStyleBackColor = true;
      this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
      // 
      // AbilityNameTB
      // 
      this.AbilityNameTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.AbilityNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.AbilityNameTB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AbilityNameTB.Location = new System.Drawing.Point(2, 6);
      this.AbilityNameTB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
      this.AbilityNameTB.Name = "AbilityNameTB";
      this.AbilityNameTB.Size = new System.Drawing.Size(137, 14);
      this.AbilityNameTB.TabIndex = 0;
      this.AbilityNameTB.TextChanged += new System.EventHandler(this.AbilityNameTB_TextChanged);
      // 
      // RemainNum
      // 
      this.RemainNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.RemainNum.Location = new System.Drawing.Point(141, 2);
      this.RemainNum.Margin = new System.Windows.Forms.Padding(0);
      this.RemainNum.Name = "RemainNum";
      this.RemainNum.Size = new System.Drawing.Size(33, 20);
      this.RemainNum.TabIndex = 1;
      this.RemainNum.ValueChanged += new System.EventHandler(this.RemainNum_ValueChanged);
      // 
      // SpendOneBtn
      // 
      this.SpendOneBtn.Dock = System.Windows.Forms.DockStyle.Left;
      this.SpendOneBtn.Location = new System.Drawing.Point(174, 0);
      this.SpendOneBtn.Margin = new System.Windows.Forms.Padding(0);
      this.SpendOneBtn.Name = "SpendOneBtn";
      this.SpendOneBtn.Size = new System.Drawing.Size(15, 24);
      this.SpendOneBtn.TabIndex = 2;
      this.SpendOneBtn.Text = "-";
      this.SpendOneBtn.UseVisualStyleBackColor = true;
      this.SpendOneBtn.Click += new System.EventHandler(this.SpendOneBtn_Click);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(189, 5);
      this.label1.Margin = new System.Windows.Forms.Padding(0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(11, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "/";
      // 
      // TotalNum
      // 
      this.TotalNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.TotalNum.Location = new System.Drawing.Point(200, 2);
      this.TotalNum.Margin = new System.Windows.Forms.Padding(0);
      this.TotalNum.Name = "TotalNum";
      this.TotalNum.Size = new System.Drawing.Size(33, 20);
      this.TotalNum.TabIndex = 3;
      this.TotalNum.ValueChanged += new System.EventHandler(this.TotalNum_ValueChanged);
      // 
      // AbilityControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "AbilityControl";
      this.Size = new System.Drawing.Size(248, 24);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button DelBtn;
    private System.Windows.Forms.TextBox AbilityNameTB;
    private CustomNumericInput RemainNum;
    private System.Windows.Forms.Button SpendOneBtn;
    private System.Windows.Forms.Label label1;
    private CustomNumericInput TotalNum;
  }
}
