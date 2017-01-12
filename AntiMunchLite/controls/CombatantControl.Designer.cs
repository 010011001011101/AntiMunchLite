﻿using System;
using System.Windows.Forms;
using AntiMunchLite.BugFix;
using Microsoft.Win32;

namespace AntiMunchLite
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

      foreach (var control in _ControlsCache)
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
      this.ArrowPB = new System.Windows.Forms.PictureBox();
      this.CombatantName = new System.Windows.Forms.TextBox();
      this.DmgBtn = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.StatusLbl = new System.Windows.Forms.Label();
      this.DelBtn = new System.Windows.Forms.Button();
      this.AddEffectBtn = new System.Windows.Forms.Button();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.EffectsFlow = new System.Windows.Forms.FlowLayoutPanel();
      this.Initiative = new AntiMunchLite.BugFix.MyNumericInput();
      this.SubInitiative = new AntiMunchLite.BugFix.MyNumericInput();
      this.CurrentHp = new AntiMunchLite.BugFix.MyNumericInput();
      this.MaxHp = new AntiMunchLite.BugFix.MyNumericInput();
      this.TableLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ArrowPB)).BeginInit();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 13;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.TableLayoutPanel.Controls.Add(this.ArrowPB, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.Initiative, 1, 0);
      this.TableLayoutPanel.Controls.Add(this.SubInitiative, 2, 0);
      this.TableLayoutPanel.Controls.Add(this.CombatantName, 3, 0);
      this.TableLayoutPanel.Controls.Add(this.DmgBtn, 6, 0);
      this.TableLayoutPanel.Controls.Add(this.label1, 7, 0);
      this.TableLayoutPanel.Controls.Add(this.CurrentHp, 8, 0);
      this.TableLayoutPanel.Controls.Add(this.label2, 9, 0);
      this.TableLayoutPanel.Controls.Add(this.MaxHp, 10, 0);
      this.TableLayoutPanel.Controls.Add(this.StatusLbl, 11, 0);
      this.TableLayoutPanel.Controls.Add(this.DelBtn, 12, 0);
      this.TableLayoutPanel.Controls.Add(this.AddEffectBtn, 4, 0);
      this.TableLayoutPanel.Controls.Add(this.EffectsFlow, 5, 0);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 1;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(696, 31);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // ArrowPB
      // 
      this.ArrowPB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.ArrowPB.Image = ((System.Drawing.Image)(resources.GetObject("ArrowPB.Image")));
      this.ArrowPB.Location = new System.Drawing.Point(3, 141);
      this.ArrowPB.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.ArrowPB.Name = "ArrowPB";
      this.ArrowPB.Size = new System.Drawing.Size(23, 23);
      this.ArrowPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.ArrowPB.TabIndex = 9;
      this.ArrowPB.TabStop = false;
      // 
      // CombatantName
      // 
      this.CombatantName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.CombatantName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.CombatantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CombatantName.Location = new System.Drawing.Point(124, 144);
      this.CombatantName.Name = "CombatantName";
      this.CombatantName.Size = new System.Drawing.Size(144, 16);
      this.CombatantName.TabIndex = 2;
      this.ToolTip.SetToolTip(this.CombatantName, "Имя");
      this.CombatantName.TextChanged += new System.EventHandler(this.CombatantName_TextChanged);
      // 
      // DmgBtn
      // 
      this.DmgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.DmgBtn.Image = ((System.Drawing.Image)(resources.GetObject("DmgBtn.Image")));
      this.DmgBtn.Location = new System.Drawing.Point(415, 138);
      this.DmgBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.DmgBtn.Name = "DmgBtn";
      this.DmgBtn.Size = new System.Drawing.Size(23, 28);
      this.DmgBtn.TabIndex = 3;
      this.DmgBtn.TabStop = false;
      this.ToolTip.SetToolTip(this.DmgBtn, "Нанести урон");
      this.DmgBtn.UseVisualStyleBackColor = true;
      this.DmgBtn.Click += new System.EventHandler(this.DmgBtn_Click);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(444, 146);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(28, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "HP :";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(525, 146);
      this.label2.Margin = new System.Windows.Forms.Padding(0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(10, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "/";
      // 
      // StatusLbl
      // 
      this.StatusLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.StatusLbl.AutoSize = true;
      this.StatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.StatusLbl.Location = new System.Drawing.Point(583, 144);
      this.StatusLbl.Name = "StatusLbl";
      this.StatusLbl.Size = new System.Drawing.Size(62, 17);
      this.StatusLbl.TabIndex = 8;
      this.StatusLbl.Text = "<status>";
      // 
      // DelBtn
      // 
      this.DelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.DelBtn.Image = ((System.Drawing.Image)(resources.GetObject("DelBtn.Image")));
      this.DelBtn.Location = new System.Drawing.Point(671, 138);
      this.DelBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.DelBtn.Name = "DelBtn";
      this.DelBtn.Size = new System.Drawing.Size(24, 28);
      this.DelBtn.TabIndex = 6;
      this.DelBtn.TabStop = false;
      this.ToolTip.SetToolTip(this.DelBtn, "Удалить");
      this.DelBtn.UseVisualStyleBackColor = true;
      this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
      // 
      // AddEffectBtn
      // 
      this.AddEffectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.AddEffectBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddEffectBtn.Image")));
      this.AddEffectBtn.Location = new System.Drawing.Point(272, 138);
      this.AddEffectBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.AddEffectBtn.Name = "AddEffectBtn";
      this.AddEffectBtn.Size = new System.Drawing.Size(24, 28);
      this.AddEffectBtn.TabIndex = 10;
      this.AddEffectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ToolTip.SetToolTip(this.AddEffectBtn, "Добавить эффект");
      this.AddEffectBtn.UseVisualStyleBackColor = true;
      this.AddEffectBtn.Click += new System.EventHandler(this.AddEffectBtn_Click);
      // 
      // ToolTip
      // 
      this.ToolTip.AutoPopDelay = 5000;
      this.ToolTip.InitialDelay = 1000;
      this.ToolTip.ReshowDelay = 100;
      // 
      // EffectsFlow
      // 
      this.EffectsFlow.Dock = System.Windows.Forms.DockStyle.Fill;
      this.EffectsFlow.Location = new System.Drawing.Point(297, 0);
      this.EffectsFlow.Margin = new System.Windows.Forms.Padding(0);
      this.EffectsFlow.Name = "EffectsFlow";
      this.EffectsFlow.Size = new System.Drawing.Size(117, 305);
      this.EffectsFlow.TabIndex = 11;
      // 
      // Initiative
      // 
      this.Initiative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.Initiative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Initiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Initiative.Location = new System.Drawing.Point(29, 141);
      this.Initiative.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.Initiative.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.Initiative.Name = "Initiative";
      this.Initiative.RepeatingDigitsCount = ((uint)(0u));
      this.Initiative.Size = new System.Drawing.Size(44, 23);
      this.Initiative.TabIndex = 0;
      this.Initiative.Text = "0";
      this.ToolTip.SetToolTip(this.Initiative, "Инициатива (Очередность хода - по убыванию)");
      this.Initiative.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.Initiative.ValueChanged += new System.EventHandler(this.Initiative_ValueChanged);
      // 
      // SubInitiative
      // 
      this.SubInitiative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.SubInitiative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.SubInitiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SubInitiative.Location = new System.Drawing.Point(79, 141);
      this.SubInitiative.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.SubInitiative.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.SubInitiative.Name = "SubInitiative";
      this.SubInitiative.RepeatingDigitsCount = ((uint)(0u));
      this.SubInitiative.Size = new System.Drawing.Size(39, 23);
      this.SubInitiative.TabIndex = 1;
      this.SubInitiative.Text = "1";
      this.ToolTip.SetToolTip(this.SubInitiative, "Порядок в одной инициативе (Очередность хода - по возрастанию)");
      this.SubInitiative.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.SubInitiative.ValueChanged += new System.EventHandler(this.SubInitiative_ValueChanged);
      // 
      // CurrentHp
      // 
      this.CurrentHp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.CurrentHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CurrentHp.Location = new System.Drawing.Point(478, 141);
      this.CurrentHp.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
      this.CurrentHp.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
      this.CurrentHp.Name = "CurrentHp";
      this.CurrentHp.RepeatingDigitsCount = ((uint)(0u));
      this.CurrentHp.Size = new System.Drawing.Size(44, 23);
      this.CurrentHp.TabIndex = 4;
      this.CurrentHp.Text = "0";
      this.ToolTip.SetToolTip(this.CurrentHp, "Текущие НР");
      this.CurrentHp.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.CurrentHp.ValueChanged += new System.EventHandler(this.CurrentHp_ValueChanged);
      // 
      // MaxHp
      // 
      this.MaxHp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.MaxHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.MaxHp.Location = new System.Drawing.Point(538, 141);
      this.MaxHp.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
      this.MaxHp.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.MaxHp.Name = "MaxHp";
      this.MaxHp.RepeatingDigitsCount = ((uint)(0u));
      this.MaxHp.Size = new System.Drawing.Size(39, 23);
      this.MaxHp.TabIndex = 5;
      this.MaxHp.Text = "0";
      this.ToolTip.SetToolTip(this.MaxHp, "Максимальные НР");
      this.MaxHp.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.MaxHp.ValueChanged += new System.EventHandler(this.MaxHp_ValueChanged);
      // 
      // CombatantControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.TableLayoutPanel);
      this.Name = "CombatantControl";
      this.Size = new System.Drawing.Size(696, 31);
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ArrowPB)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.TextBox CombatantName;
    private System.Windows.Forms.Label label1;
    private MyNumericInput CurrentHp;
    private System.Windows.Forms.Label label2;
    private MyNumericInput MaxHp;
    private System.Windows.Forms.Button DelBtn;
    private MyNumericInput Initiative;
    private System.Windows.Forms.Label StatusLbl;
    private System.Windows.Forms.Button DmgBtn;
    private MyNumericInput SubInitiative;
    private ToolTip ToolTip;
    private PictureBox ArrowPB;
    private Button AddEffectBtn;
    private FlowLayoutPanel EffectsFlow;
  }
}