namespace AntiMunchLite
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.ToolBar = new System.Windows.Forms.ToolStrip();
      this.MainFlow = new System.Windows.Forms.FlowLayoutPanel();
      this.AddBtn = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.NextBtn = new System.Windows.Forms.ToolStripButton();
      this.RoundLbl = new System.Windows.Forms.ToolStripLabel();
      this.ToolBar.SuspendLayout();
      this.SuspendLayout();
      // 
      // ToolBar
      // 
      this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn,
            this.toolStripSeparator1,
            this.NextBtn,
            this.RoundLbl});
      this.ToolBar.Location = new System.Drawing.Point(0, 0);
      this.ToolBar.Name = "ToolBar";
      this.ToolBar.Size = new System.Drawing.Size(645, 25);
      this.ToolBar.TabIndex = 0;
      this.ToolBar.Text = "toolStrip1";
      // 
      // MainFlow
      // 
      this.MainFlow.AutoScroll = true;
      this.MainFlow.BackColor = System.Drawing.Color.White;
      this.MainFlow.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.MainFlow.Location = new System.Drawing.Point(0, 25);
      this.MainFlow.Name = "MainFlow";
      this.MainFlow.Size = new System.Drawing.Size(645, 341);
      this.MainFlow.TabIndex = 1;
      this.MainFlow.WrapContents = false;
      // 
      // AddBtn
      // 
      this.AddBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
      this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(23, 22);
      this.AddBtn.Text = "Add Combatant";
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // NextBtn
      // 
      this.NextBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.NextBtn.Image = ((System.Drawing.Image)(resources.GetObject("NextBtn.Image")));
      this.NextBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.NextBtn.Name = "NextBtn";
      this.NextBtn.Size = new System.Drawing.Size(55, 22);
      this.NextBtn.Text = "Next";
      this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
      // 
      // RoundLbl
      // 
      this.RoundLbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.RoundLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.RoundLbl.ForeColor = System.Drawing.Color.DarkRed;
      this.RoundLbl.Name = "RoundLbl";
      this.RoundLbl.Size = new System.Drawing.Size(67, 22);
      this.RoundLbl.Text = "<Round ?>";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(645, 366);
      this.Controls.Add(this.MainFlow);
      this.Controls.Add(this.ToolBar);
      this.Name = "MainForm";
      this.ShowIcon = false;
      this.Text = "AntiMunch Lite";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
      this.ToolBar.ResumeLayout(false);
      this.ToolBar.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip ToolBar;
    private System.Windows.Forms.ToolStripButton AddBtn;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton NextBtn;
    private System.Windows.Forms.ToolStripLabel RoundLbl;
    private System.Windows.Forms.FlowLayoutPanel MainFlow;
  }
}