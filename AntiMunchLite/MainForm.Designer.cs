﻿using System.Windows.Forms;
using AntiMunchLite.BaseControls;

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

      foreach (var control in _CombatantControlsCache)
        control.Dispose();

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
      this.MenuList = new System.Windows.Forms.ToolStripDropDownButton();
      this.SaveBtn = new System.Windows.Forms.ToolStripMenuItem();
      this.OpenBtn = new System.Windows.Forms.ToolStripMenuItem();
      this.LoadAddBtn = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.ShowPreGenEffects = new System.Windows.Forms.ToolStripMenuItem();
      this.AbilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.AddBtn = new System.Windows.Forms.ToolStripButton();
      this.CloneBtn = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.NextBtn = new System.Windows.Forms.ToolStripButton();
      this.NextRoundBtn = new System.Windows.Forms.ToolStripButton();
      this.RoundLbl = new System.Windows.Forms.ToolStripLabel();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ResetBtn = new System.Windows.Forms.ToolStripButton();
      this.MainFlow = new AntiMunchLite.BaseControls.DoubleBufferedFlow();
      this.ToolBar.SuspendLayout();
      this.SuspendLayout();
      // 
      // ToolBar
      // 
      this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuList,
            this.toolStripSeparator3,
            this.AddBtn,
            this.CloneBtn,
            this.toolStripSeparator1,
            this.NextBtn,
            this.NextRoundBtn,
            this.RoundLbl,
            this.toolStripSeparator2,
            this.ResetBtn});
      this.ToolBar.Location = new System.Drawing.Point(0, 0);
      this.ToolBar.Name = "ToolBar";
      this.ToolBar.Size = new System.Drawing.Size(884, 25);
      this.ToolBar.TabIndex = 0;
      this.ToolBar.Text = "toolStrip1";
      // 
      // MenuList
      // 
      this.MenuList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.MenuList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveBtn,
            this.OpenBtn,
            this.LoadAddBtn,
            this.toolStripSeparator4,
            this.ShowPreGenEffects,
            this.AbilitiesToolStripMenuItem});
      this.MenuList.Image = ((System.Drawing.Image)(resources.GetObject("MenuList.Image")));
      this.MenuList.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.MenuList.Name = "MenuList";
      this.MenuList.Size = new System.Drawing.Size(51, 22);
      this.MenuList.Text = "Menu";
      // 
      // SaveBtn
      // 
      this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
      this.SaveBtn.Name = "SaveBtn";
      this.SaveBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.SaveBtn.Size = new System.Drawing.Size(165, 22);
      this.SaveBtn.Text = "Save";
      this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
      // 
      // OpenBtn
      // 
      this.OpenBtn.Image = ((System.Drawing.Image)(resources.GetObject("OpenBtn.Image")));
      this.OpenBtn.Name = "OpenBtn";
      this.OpenBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.OpenBtn.Size = new System.Drawing.Size(165, 22);
      this.OpenBtn.Text = "Open";
      this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
      // 
      // LoadAddBtn
      // 
      this.LoadAddBtn.Image = ((System.Drawing.Image)(resources.GetObject("LoadAddBtn.Image")));
      this.LoadAddBtn.Name = "LoadAddBtn";
      this.LoadAddBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
      this.LoadAddBtn.Size = new System.Drawing.Size(165, 22);
      this.LoadAddBtn.Text = "Load Add";
      this.LoadAddBtn.Click += new System.EventHandler(this.LoadAddBtn_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(162, 6);
      // 
      // ShowPreGenEffects
      // 
      this.ShowPreGenEffects.Name = "ShowPreGenEffects";
      this.ShowPreGenEffects.Size = new System.Drawing.Size(165, 22);
      this.ShowPreGenEffects.Text = "Effects...";
      this.ShowPreGenEffects.Click += new System.EventHandler(this.ShowPreGenEffects_Click);
      // 
      // AbilitiesToolStripMenuItem
      // 
      this.AbilitiesToolStripMenuItem.Name = "AbilitiesToolStripMenuItem";
      this.AbilitiesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
      this.AbilitiesToolStripMenuItem.Text = "Abilities...";
      this.AbilitiesToolStripMenuItem.Click += new System.EventHandler(this.AbilitiesToolStripMenuItem_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // AddBtn
      // 
      this.AddBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
      this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(23, 22);
      this.AddBtn.Text = "Add Combatant";
      this.AddBtn.ToolTipText = "Add Combatant (Ctrl+N)";
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
      // 
      // CloneBtn
      // 
      this.CloneBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.CloneBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloneBtn.Image")));
      this.CloneBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.CloneBtn.Name = "CloneBtn";
      this.CloneBtn.Size = new System.Drawing.Size(23, 22);
      this.CloneBtn.Text = "Clone Combatant(s)";
      this.CloneBtn.ToolTipText = "Clone Combatant(s) (Ctrl+P)";
      this.CloneBtn.Click += new System.EventHandler(this.CloneBtn_Click);
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
      this.NextBtn.ToolTipText = "Next (Ctrl+Enter)";
      this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
      // 
      // NextRoundBtn
      // 
      this.NextRoundBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.NextRoundBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.NextRoundBtn.Image = ((System.Drawing.Image)(resources.GetObject("NextRoundBtn.Image")));
      this.NextRoundBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.NextRoundBtn.Name = "NextRoundBtn";
      this.NextRoundBtn.Size = new System.Drawing.Size(78, 22);
      this.NextRoundBtn.Text = "Next Round";
      this.NextRoundBtn.Click += new System.EventHandler(this.NextRoundBtn_Click);
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
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // ResetBtn
      // 
      this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.ResetBtn.Image = ((System.Drawing.Image)(resources.GetObject("ResetBtn.Image")));
      this.ResetBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ResetBtn.Name = "ResetBtn";
      this.ResetBtn.Size = new System.Drawing.Size(59, 22);
      this.ResetBtn.Text = "Reset";
      this.ResetBtn.ToolTipText = "Reset (Ctrl+R)";
      this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
      // 
      // MainFlow
      // 
      this.MainFlow.AllowDrop = true;
      this.MainFlow.AutoScroll = true;
      this.MainFlow.BackColor = System.Drawing.Color.White;
      this.MainFlow.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.MainFlow.Location = new System.Drawing.Point(0, 25);
      this.MainFlow.Name = "MainFlow";
      this.MainFlow.Size = new System.Drawing.Size(884, 337);
      this.MainFlow.TabIndex = 1;
      this.MainFlow.WrapContents = false;
      this.MainFlow.DragOver += new System.Windows.Forms.DragEventHandler(this.MainFlow_DragOver);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(884, 362);
      this.Controls.Add(this.MainFlow);
      this.Controls.Add(this.ToolBar);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Name = "MainForm";
      this.Text = "AntiMunch Lite";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
      this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
      this.Resize += new System.EventHandler(this.MainForm_Resize);
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
    private DoubleBufferedFlow MainFlow;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton ResetBtn;
    private System.Windows.Forms.ToolStripDropDownButton MenuList;
    private System.Windows.Forms.ToolStripMenuItem SaveBtn;
    private System.Windows.Forms.ToolStripMenuItem OpenBtn;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton NextRoundBtn;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem ShowPreGenEffects;
    private System.Windows.Forms.ToolStripMenuItem LoadAddBtn;
    private System.Windows.Forms.ToolStripMenuItem AbilitiesToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton CloneBtn;
  }
}