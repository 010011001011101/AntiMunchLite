﻿namespace AntiMunchLite
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
      this.AddBtn = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.NextBtn = new System.Windows.Forms.ToolStripButton();
      this.RoundLbl = new System.Windows.Forms.ToolStripLabel();
      this.MainFlow = new System.Windows.Forms.FlowLayoutPanel();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ResetBtn = new System.Windows.Forms.ToolStripButton();
      this.Menu = new System.Windows.Forms.ToolStripDropDownButton();
      this.SaveBtn = new System.Windows.Forms.ToolStripMenuItem();
      this.LoadBtn = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.ToolBar.SuspendLayout();
      this.SuspendLayout();
      // 
      // ToolBar
      // 
      this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.toolStripSeparator3,
            this.AddBtn,
            this.toolStripSeparator1,
            this.NextBtn,
            this.RoundLbl,
            this.toolStripSeparator2,
            this.ResetBtn});
      this.ToolBar.Location = new System.Drawing.Point(0, 0);
      this.ToolBar.Name = "ToolBar";
      this.ToolBar.Size = new System.Drawing.Size(645, 25);
      this.ToolBar.TabIndex = 0;
      this.ToolBar.Text = "toolStrip1";
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
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // ResetBtn
      // 
      this.ResetBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ResetBtn.Image = ((System.Drawing.Image)(resources.GetObject("ResetBtn.Image")));
      this.ResetBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ResetBtn.Name = "ResetBtn";
      this.ResetBtn.Size = new System.Drawing.Size(23, 22);
      this.ResetBtn.Text = "Reset Encounter";
      this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
      // 
      // Menu
      // 
      this.Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveBtn,
            this.LoadBtn});
      this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
      this.Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.Menu.Name = "Menu";
      this.Menu.Size = new System.Drawing.Size(51, 22);
      this.Menu.Text = "Menu";
      // 
      // SaveBtn
      // 
      this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
      this.SaveBtn.Name = "SaveBtn";
      this.SaveBtn.Size = new System.Drawing.Size(152, 22);
      this.SaveBtn.Text = "Save";
      this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
      // 
      // LoadBtn
      // 
      this.LoadBtn.Image = ((System.Drawing.Image)(resources.GetObject("LoadBtn.Image")));
      this.LoadBtn.Name = "LoadBtn";
      this.LoadBtn.Size = new System.Drawing.Size(152, 22);
      this.LoadBtn.Text = "Load";
      this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton ResetBtn;
    private System.Windows.Forms.ToolStripDropDownButton Menu;
    private System.Windows.Forms.ToolStripMenuItem SaveBtn;
    private System.Windows.Forms.ToolStripMenuItem LoadBtn;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
  }
}