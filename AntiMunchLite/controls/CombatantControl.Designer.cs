﻿using System.Windows.Forms;
using AntiMunchLite.BaseControls;

namespace AntiMunchLite.Controls
{
  partial class CombatantControl
  {
    /// <summary> 
    /// Требуется переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }

      foreach (var control in _EffectsControlsCache)
        control.Dispose();

      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Обязательный метод для поддержки конструктора - не изменяйте 
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombatantControl));
      this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.HealBtn = new System.Windows.Forms.Button();
      this.ArrowPB = new System.Windows.Forms.PictureBox();
      this.Initiative = new AntiMunchLite.BaseControls.CustomNumericInput();
      this.SubInitiative = new AntiMunchLite.BaseControls.CustomNumericInput();
      this.CombatantName = new System.Windows.Forms.TextBox();
      this.DmgBtn = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.CurrentHp = new AntiMunchLite.BaseControls.CustomNumericInput();
      this.label2 = new System.Windows.Forms.Label();
      this.MaxHp = new AntiMunchLite.BaseControls.CustomNumericInput();
      this.StatusLbl = new System.Windows.Forms.Label();
      this.DelBtn = new System.Windows.Forms.Button();
      this.DragPB = new System.Windows.Forms.PictureBox();
      this.ShowBoxesFlow = new System.Windows.Forms.FlowLayoutPanel();
      this.ShowEffectsCB = new System.Windows.Forms.CheckBox();
      this.ShowCommentCB = new System.Windows.Forms.CheckBox();
      this.ShowAbilitiesCB = new System.Windows.Forms.CheckBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.AddEffectBtn = new System.Windows.Forms.Button();
      this.EffectsFlow = new AntiMunchLite.BaseControls.DoubleBufferedFlow();
      this.label3 = new System.Windows.Forms.Label();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.AddAbilityBtn = new System.Windows.Forms.Button();
      this.AbilitiesFlow = new AntiMunchLite.BaseControls.DoubleBufferedFlow();
      this.Comment = new System.Windows.Forms.TextBox();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.TableLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ArrowPB)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DragPB)).BeginInit();
      this.ShowBoxesFlow.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 14;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.TableLayoutPanel.Controls.Add(this.label5, 0, 3);
      this.TableLayoutPanel.Controls.Add(this.label4, 0, 2);
      this.TableLayoutPanel.Controls.Add(this.HealBtn, 6, 0);
      this.TableLayoutPanel.Controls.Add(this.ArrowPB, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.Initiative, 2, 0);
      this.TableLayoutPanel.Controls.Add(this.SubInitiative, 3, 0);
      this.TableLayoutPanel.Controls.Add(this.CombatantName, 4, 0);
      this.TableLayoutPanel.Controls.Add(this.DmgBtn, 5, 0);
      this.TableLayoutPanel.Controls.Add(this.label1, 7, 0);
      this.TableLayoutPanel.Controls.Add(this.CurrentHp, 8, 0);
      this.TableLayoutPanel.Controls.Add(this.label2, 9, 0);
      this.TableLayoutPanel.Controls.Add(this.MaxHp, 10, 0);
      this.TableLayoutPanel.Controls.Add(this.StatusLbl, 11, 0);
      this.TableLayoutPanel.Controls.Add(this.DelBtn, 13, 0);
      this.TableLayoutPanel.Controls.Add(this.DragPB, 1, 0);
      this.TableLayoutPanel.Controls.Add(this.ShowBoxesFlow, 12, 0);
      this.TableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 3, 1);
      this.TableLayoutPanel.Controls.Add(this.label3, 0, 1);
      this.TableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 3, 3);
      this.TableLayoutPanel.Controls.Add(this.Comment, 3, 2);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 5;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(840, 140);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // label5
      // 
      this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label5.AutoSize = true;
      this.TableLayoutPanel.SetColumnSpan(this.label5, 3);
      this.label5.Location = new System.Drawing.Point(44, 115);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(48, 13);
      this.label5.TabIndex = 17;
      this.label5.Text = "Abilities :";
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label4.AutoSize = true;
      this.TableLayoutPanel.SetColumnSpan(this.label4, 3);
      this.label4.Location = new System.Drawing.Point(35, 78);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(57, 13);
      this.label4.TabIndex = 16;
      this.label4.Text = "Comment :";
      // 
      // HealBtn
      // 
      this.HealBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.HealBtn.Image = ((System.Drawing.Image)(resources.GetObject("HealBtn.Image")));
      this.HealBtn.Location = new System.Drawing.Point(336, 3);
      this.HealBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.HealBtn.Name = "HealBtn";
      this.HealBtn.Size = new System.Drawing.Size(23, 26);
      this.HealBtn.TabIndex = 4;
      this.HealBtn.TabStop = false;
      this.ToolTip.SetToolTip(this.HealBtn, "Heal (Ctrl+H)");
      this.HealBtn.UseVisualStyleBackColor = true;
      this.HealBtn.Click += new System.EventHandler(this.HealBtn_Click);
      // 
      // ArrowPB
      // 
      this.ArrowPB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.ArrowPB.Image = ((System.Drawing.Image)(resources.GetObject("ArrowPB.Image")));
      this.ArrowPB.Location = new System.Drawing.Point(3, 4);
      this.ArrowPB.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.ArrowPB.Name = "ArrowPB";
      this.ArrowPB.Size = new System.Drawing.Size(23, 23);
      this.ArrowPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.ArrowPB.TabIndex = 9;
      this.ArrowPB.TabStop = false;
      // 
      // Initiative
      // 
      this.Initiative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.Initiative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Initiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Initiative.Location = new System.Drawing.Point(48, 4);
      this.Initiative.Maximum = null;
      this.Initiative.Minimum = null;
      this.Initiative.Name = "Initiative";
      this.Initiative.Size = new System.Drawing.Size(44, 23);
      this.Initiative.TabIndex = 0;
      this.Initiative.Text = "0";
      this.Initiative.ToolTip = "Initiative Order (desc)";
      this.Initiative.Value = 0;
      this.Initiative.ValueChanged += new System.EventHandler(this.Initiative_ValueChanged);
      // 
      // SubInitiative
      // 
      this.SubInitiative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.SubInitiative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.SubInitiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SubInitiative.Location = new System.Drawing.Point(98, 4);
      this.SubInitiative.Maximum = null;
      this.SubInitiative.Minimum = null;
      this.SubInitiative.Name = "SubInitiative";
      this.SubInitiative.Size = new System.Drawing.Size(39, 23);
      this.SubInitiative.TabIndex = 1;
      this.SubInitiative.TabStop = false;
      this.SubInitiative.Text = "1";
      this.SubInitiative.ToolTip = "SubInitiative Order (desc)";
      this.SubInitiative.Value = 1;
      this.SubInitiative.ValueChanged += new System.EventHandler(this.SubInitiative_ValueChanged);
      // 
      // CombatantName
      // 
      this.CombatantName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.CombatantName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.CombatantName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CombatantName.Location = new System.Drawing.Point(143, 8);
      this.CombatantName.Name = "CombatantName";
      this.CombatantName.Size = new System.Drawing.Size(164, 16);
      this.CombatantName.TabIndex = 2;
      this.ToolTip.SetToolTip(this.CombatantName, "Name");
      this.CombatantName.TextChanged += new System.EventHandler(this.CombatantName_TextChanged);
      // 
      // DmgBtn
      // 
      this.DmgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.DmgBtn.Image = ((System.Drawing.Image)(resources.GetObject("DmgBtn.Image")));
      this.DmgBtn.Location = new System.Drawing.Point(311, 3);
      this.DmgBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.DmgBtn.Name = "DmgBtn";
      this.DmgBtn.Size = new System.Drawing.Size(23, 26);
      this.DmgBtn.TabIndex = 3;
      this.DmgBtn.TabStop = false;
      this.ToolTip.SetToolTip(this.DmgBtn, "Deal Damage (Ctrl+D)");
      this.DmgBtn.UseVisualStyleBackColor = true;
      this.DmgBtn.Click += new System.EventHandler(this.DmgBtn_Click);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(365, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(28, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "HP :";
      // 
      // CurrentHp
      // 
      this.CurrentHp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.CurrentHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CurrentHp.Location = new System.Drawing.Point(399, 4);
      this.CurrentHp.Maximum = null;
      this.CurrentHp.Minimum = null;
      this.CurrentHp.Name = "CurrentHp";
      this.CurrentHp.Size = new System.Drawing.Size(44, 23);
      this.CurrentHp.TabIndex = 6;
      this.CurrentHp.Text = "0";
      this.CurrentHp.ToolTip = "Current HP";
      this.CurrentHp.Value = 0;
      this.CurrentHp.ValueChanged += new System.EventHandler(this.CurrentHp_ValueChanged);
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(446, 9);
      this.label2.Margin = new System.Windows.Forms.Padding(0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(10, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "/";
      // 
      // MaxHp
      // 
      this.MaxHp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.MaxHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.MaxHp.Location = new System.Drawing.Point(459, 4);
      this.MaxHp.Maximum = null;
      this.MaxHp.Minimum = 0;
      this.MaxHp.Name = "MaxHp";
      this.MaxHp.Size = new System.Drawing.Size(44, 23);
      this.MaxHp.TabIndex = 8;
      this.MaxHp.Text = "0";
      this.MaxHp.ToolTip = "Maximum HP";
      this.MaxHp.Value = 0;
      this.MaxHp.ValueChanged += new System.EventHandler(this.MaxHp_ValueChanged);
      // 
      // StatusLbl
      // 
      this.StatusLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.StatusLbl.AutoSize = true;
      this.StatusLbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.StatusLbl.Location = new System.Drawing.Point(509, 8);
      this.StatusLbl.Name = "StatusLbl";
      this.StatusLbl.Size = new System.Drawing.Size(62, 16);
      this.StatusLbl.TabIndex = 9;
      this.StatusLbl.Text = "<status>";
      // 
      // DelBtn
      // 
      this.DelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.DelBtn.Image = ((System.Drawing.Image)(resources.GetObject("DelBtn.Image")));
      this.DelBtn.Location = new System.Drawing.Point(815, 3);
      this.DelBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.DelBtn.Name = "DelBtn";
      this.DelBtn.Size = new System.Drawing.Size(24, 26);
      this.DelBtn.TabIndex = 14;
      this.DelBtn.TabStop = false;
      this.ToolTip.SetToolTip(this.DelBtn, "Delete");
      this.DelBtn.UseVisualStyleBackColor = true;
      this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
      // 
      // DragPB
      // 
      this.DragPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.DragPB.Cursor = System.Windows.Forms.Cursors.SizeNS;
      this.DragPB.Location = new System.Drawing.Point(29, 8);
      this.DragPB.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
      this.DragPB.Name = "DragPB";
      this.DragPB.Size = new System.Drawing.Size(16, 16);
      this.DragPB.TabIndex = 13;
      this.DragPB.TabStop = false;
      this.ToolTip.SetToolTip(this.DragPB, "Shift Initiative");
      this.DragPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPB_MouseDown);
      // 
      // ShowBoxesFlow
      // 
      this.ShowBoxesFlow.Controls.Add(this.ShowEffectsCB);
      this.ShowBoxesFlow.Controls.Add(this.ShowCommentCB);
      this.ShowBoxesFlow.Controls.Add(this.ShowAbilitiesCB);
      this.ShowBoxesFlow.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ShowBoxesFlow.Location = new System.Drawing.Point(599, 6);
      this.ShowBoxesFlow.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
      this.ShowBoxesFlow.Name = "ShowBoxesFlow";
      this.ShowBoxesFlow.Size = new System.Drawing.Size(212, 23);
      this.ShowBoxesFlow.TabIndex = 10;
      // 
      // ShowEffectsCB
      // 
      this.ShowEffectsCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.ShowEffectsCB.AutoSize = true;
      this.ShowEffectsCB.Location = new System.Drawing.Point(3, 3);
      this.ShowEffectsCB.Name = "ShowEffectsCB";
      this.ShowEffectsCB.Size = new System.Drawing.Size(59, 17);
      this.ShowEffectsCB.TabIndex = 0;
      this.ShowEffectsCB.Text = "Effects";
      this.ShowEffectsCB.UseVisualStyleBackColor = true;
      this.ShowEffectsCB.CheckedChanged += new System.EventHandler(this.ShowEffectsCB_CheckedChanged);
      // 
      // ShowCommentCB
      // 
      this.ShowCommentCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.ShowCommentCB.AutoSize = true;
      this.ShowCommentCB.Location = new System.Drawing.Point(68, 3);
      this.ShowCommentCB.Name = "ShowCommentCB";
      this.ShowCommentCB.Size = new System.Drawing.Size(70, 17);
      this.ShowCommentCB.TabIndex = 1;
      this.ShowCommentCB.Text = "Comment";
      this.ShowCommentCB.UseVisualStyleBackColor = true;
      this.ShowCommentCB.CheckedChanged += new System.EventHandler(this.ShowCommentCB_CheckedChanged);
      // 
      // ShowAbilitiesCB
      // 
      this.ShowAbilitiesCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.ShowAbilitiesCB.AutoSize = true;
      this.ShowAbilitiesCB.Location = new System.Drawing.Point(144, 3);
      this.ShowAbilitiesCB.Name = "ShowAbilitiesCB";
      this.ShowAbilitiesCB.Size = new System.Drawing.Size(61, 17);
      this.ShowAbilitiesCB.TabIndex = 2;
      this.ShowAbilitiesCB.Text = "Abilities";
      this.ShowAbilitiesCB.UseVisualStyleBackColor = true;
      this.ShowAbilitiesCB.CheckedChanged += new System.EventHandler(this.ShowAbilitiesCB_CheckedChanged);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.TableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 11);
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Controls.Add(this.AddEffectBtn, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.EffectsFlow, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(95, 32);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(745, 30);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // AddEffectBtn
      // 
      this.AddEffectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.AddEffectBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddEffectBtn.Image")));
      this.AddEffectBtn.Location = new System.Drawing.Point(1, 2);
      this.AddEffectBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.AddEffectBtn.Name = "AddEffectBtn";
      this.AddEffectBtn.Size = new System.Drawing.Size(26, 26);
      this.AddEffectBtn.TabIndex = 0;
      this.AddEffectBtn.TabStop = false;
      this.AddEffectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ToolTip.SetToolTip(this.AddEffectBtn, "Add Effect  (Ctrl+E)");
      this.AddEffectBtn.UseVisualStyleBackColor = true;
      this.AddEffectBtn.Click += new System.EventHandler(this.AddEffectBtn_Click);
      // 
      // EffectsFlow
      // 
      this.EffectsFlow.Dock = System.Windows.Forms.DockStyle.Fill;
      this.EffectsFlow.Location = new System.Drawing.Point(28, 0);
      this.EffectsFlow.Margin = new System.Windows.Forms.Padding(0);
      this.EffectsFlow.Name = "EffectsFlow";
      this.EffectsFlow.Size = new System.Drawing.Size(717, 30);
      this.EffectsFlow.TabIndex = 1;
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label3.AutoSize = true;
      this.TableLayoutPanel.SetColumnSpan(this.label3, 3);
      this.label3.Location = new System.Drawing.Point(46, 40);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 13);
      this.label3.TabIndex = 15;
      this.label3.Text = "Effects :";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.TableLayoutPanel.SetColumnSpan(this.tableLayoutPanel2, 11);
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.AddAbilityBtn, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.AbilitiesFlow, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(95, 107);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(745, 30);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // AddAbilityBtn
      // 
      this.AddAbilityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.AddAbilityBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddAbilityBtn.Image")));
      this.AddAbilityBtn.Location = new System.Drawing.Point(1, 2);
      this.AddAbilityBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.AddAbilityBtn.Name = "AddAbilityBtn";
      this.AddAbilityBtn.Size = new System.Drawing.Size(26, 26);
      this.AddAbilityBtn.TabIndex = 0;
      this.AddAbilityBtn.TabStop = false;
      this.AddAbilityBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ToolTip.SetToolTip(this.AddAbilityBtn, "Add Ability");
      this.AddAbilityBtn.UseVisualStyleBackColor = true;
      this.AddAbilityBtn.Click += new System.EventHandler(this.AddAbilityBtn_Click);
      // 
      // AbilitiesFlow
      // 
      this.AbilitiesFlow.Dock = System.Windows.Forms.DockStyle.Fill;
      this.AbilitiesFlow.Location = new System.Drawing.Point(28, 0);
      this.AbilitiesFlow.Margin = new System.Windows.Forms.Padding(0);
      this.AbilitiesFlow.Name = "AbilitiesFlow";
      this.AbilitiesFlow.Size = new System.Drawing.Size(717, 30);
      this.AbilitiesFlow.TabIndex = 1;
      // 
      // Comment
      // 
      this.Comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TableLayoutPanel.SetColumnSpan(this.Comment, 11);
      this.Comment.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Comment.Location = new System.Drawing.Point(98, 65);
      this.Comment.Multiline = true;
      this.Comment.Name = "Comment";
      this.Comment.Size = new System.Drawing.Size(739, 39);
      this.Comment.TabIndex = 18;
      this.Comment.TextChanged += new System.EventHandler(this.Comment_TextChanged);
      // 
      // ToolTip
      // 
      this.ToolTip.AutoPopDelay = 5000;
      this.ToolTip.InitialDelay = 1000;
      this.ToolTip.ReshowDelay = 100;
      // 
      // CombatantControl
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.TableLayoutPanel);
      this.MinimumSize = new System.Drawing.Size(840, 32);
      this.Name = "CombatantControl";
      this.Size = new System.Drawing.Size(840, 140);
      this.DragOver += new System.Windows.Forms.DragEventHandler(this.CombatantControl_DragOver);
      this.DragLeave += new System.EventHandler(this.CombatantControl_DragLeave);
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ArrowPB)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DragPB)).EndInit();
      this.ShowBoxesFlow.ResumeLayout(false);
      this.ShowBoxesFlow.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.TextBox CombatantName;
    private System.Windows.Forms.Label label1;
    private CustomNumericInput CurrentHp;
    private System.Windows.Forms.Label label2;
    private CustomNumericInput MaxHp;
    private System.Windows.Forms.Button DelBtn;
    private CustomNumericInput Initiative;
    private System.Windows.Forms.Label StatusLbl;
    private System.Windows.Forms.Button DmgBtn;
    private CustomNumericInput SubInitiative;
    private ToolTip ToolTip;
    private PictureBox ArrowPB;
    private Button AddEffectBtn;
    private DoubleBufferedFlow EffectsFlow;
    private Button HealBtn;
    private PictureBox DragPB;
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private Button AddAbilityBtn;
    private FlowLayoutPanel ShowBoxesFlow;
    private CheckBox ShowEffectsCB;
    private CheckBox ShowCommentCB;
    private CheckBox ShowAbilitiesCB;
    private DoubleBufferedFlow AbilitiesFlow;
    private Label label5;
    private Label label4;
    private Label label3;
    private TextBox Comment;
  }
}
