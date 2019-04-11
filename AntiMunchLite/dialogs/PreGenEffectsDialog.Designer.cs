namespace AntiMunchLite.Dialogs
{
  partial class PreGenEffectsDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreGenEffectsDialog));
      this.ToolStripContainer = new System.Windows.Forms.ToolStripContainer();
      this.PreGenEffects = new System.Windows.Forms.CheckedListBox();
      this.ToolBar = new System.Windows.Forms.ToolStrip();
      this.AddBtn = new System.Windows.Forms.ToolStripButton();
      this.NewEffectName = new System.Windows.Forms.ToolStripTextBox();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.DelBtn = new System.Windows.Forms.ToolStripButton();
      this.ToolStripContainer.ContentPanel.SuspendLayout();
      this.ToolStripContainer.TopToolStripPanel.SuspendLayout();
      this.ToolStripContainer.SuspendLayout();
      this.ToolBar.SuspendLayout();
      this.SuspendLayout();
      // 
      // ToolStripContainer
      // 
      this.ToolStripContainer.BottomToolStripPanelVisible = false;
      // 
      // ToolStripContainer.ContentPanel
      // 
      this.ToolStripContainer.ContentPanel.Controls.Add(this.PreGenEffects);
      this.ToolStripContainer.ContentPanel.Size = new System.Drawing.Size(230, 288);
      this.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ToolStripContainer.LeftToolStripPanelVisible = false;
      this.ToolStripContainer.Location = new System.Drawing.Point(0, 0);
      this.ToolStripContainer.Name = "ToolStripContainer";
      this.ToolStripContainer.RightToolStripPanelVisible = false;
      this.ToolStripContainer.Size = new System.Drawing.Size(230, 315);
      this.ToolStripContainer.TabIndex = 0;
      this.ToolStripContainer.Text = "toolStripContainer1";
      // 
      // ToolStripContainer.TopToolStripPanel
      // 
      this.ToolStripContainer.TopToolStripPanel.Controls.Add(this.ToolBar);
      // 
      // PreGenEffects
      // 
      this.PreGenEffects.CheckOnClick = true;
      this.PreGenEffects.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PreGenEffects.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PreGenEffects.FormattingEnabled = true;
      this.PreGenEffects.Location = new System.Drawing.Point(0, 0);
      this.PreGenEffects.Name = "PreGenEffects";
      this.PreGenEffects.Size = new System.Drawing.Size(230, 288);
      this.PreGenEffects.TabIndex = 0;
      // 
      // ToolBar
      // 
      this.ToolBar.Dock = System.Windows.Forms.DockStyle.None;
      this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.ToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn,
            this.NewEffectName,
            this.toolStripSeparator1,
            this.DelBtn});
      this.ToolBar.Location = new System.Drawing.Point(0, 0);
      this.ToolBar.Name = "ToolBar";
      this.ToolBar.Size = new System.Drawing.Size(230, 27);
      this.ToolBar.Stretch = true;
      this.ToolBar.TabIndex = 0;
      // 
      // AddBtn
      // 
      this.AddBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
      this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(24, 24);
      this.AddBtn.Text = "Add";
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
      // 
      // NewEffectName
      // 
      this.NewEffectName.Name = "NewEffectName";
      this.NewEffectName.Size = new System.Drawing.Size(150, 27);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
      // 
      // DelBtn
      // 
      this.DelBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.DelBtn.Image = ((System.Drawing.Image)(resources.GetObject("DelBtn.Image")));
      this.DelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.DelBtn.Name = "DelBtn";
      this.DelBtn.Size = new System.Drawing.Size(24, 24);
      this.DelBtn.Text = "Delete";
      this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
      // 
      // PreGenEffectsDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(230, 315);
      this.Controls.Add(this.ToolStripContainer);
      this.MinimizeBox = false;
      this.Name = "PreGenEffectsDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Effects list";
      this.ToolStripContainer.ContentPanel.ResumeLayout(false);
      this.ToolStripContainer.TopToolStripPanel.ResumeLayout(false);
      this.ToolStripContainer.TopToolStripPanel.PerformLayout();
      this.ToolStripContainer.ResumeLayout(false);
      this.ToolStripContainer.PerformLayout();
      this.ToolBar.ResumeLayout(false);
      this.ToolBar.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStripContainer ToolStripContainer;
    private System.Windows.Forms.CheckedListBox PreGenEffects;
    private System.Windows.Forms.ToolStrip ToolBar;
    private System.Windows.Forms.ToolStripButton AddBtn;
    private System.Windows.Forms.ToolStripTextBox NewEffectName;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton DelBtn;

  }
}