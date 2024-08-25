using AntiMunchLite.BaseControls;

namespace AntiMunchLite
{
  partial class DmgDialog
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
      TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      OkBtn = new System.Windows.Forms.Button();
      CancelBtn = new System.Windows.Forms.Button();
      CombotantsFlow = new DoubleBufferedFlow();
      LabelTable = new System.Windows.Forms.TableLayoutPanel();
      label2 = new System.Windows.Forms.Label();
      label3 = new System.Windows.Forms.Label();
      label4 = new System.Windows.Forms.Label();
      tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      IsHeal = new System.Windows.Forms.RadioButton();
      IsDmg = new System.Windows.Forms.RadioButton();
      NoOverheal = new System.Windows.Forms.CheckBox();
      tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      DmgCounter = new CustomNumericInput();
      RollB = new System.Windows.Forms.Button();
      RollResultT = new System.Windows.Forms.TextBox();
      TableLayoutPanel.SuspendLayout();
      LabelTable.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      tableLayoutPanel2.SuspendLayout();
      SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      TableLayoutPanel.ColumnCount = 3;
      TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
      TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
      TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      TableLayoutPanel.Controls.Add(OkBtn, 1, 4);
      TableLayoutPanel.Controls.Add(CancelBtn, 2, 4);
      TableLayoutPanel.Controls.Add(CombotantsFlow, 0, 1);
      TableLayoutPanel.Controls.Add(LabelTable, 0, 0);
      TableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 2);
      TableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 3);
      TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      TableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
      TableLayoutPanel.Name = "TableLayoutPanel";
      TableLayoutPanel.RowCount = 5;
      TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
      TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
      TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
      TableLayoutPanel.Size = new System.Drawing.Size(452, 533);
      TableLayoutPanel.TabIndex = 0;
      // 
      // OkBtn
      // 
      OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      OkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      OkBtn.Location = new System.Drawing.Point(290, 504);
      OkBtn.Margin = new System.Windows.Forms.Padding(2);
      OkBtn.Name = "OkBtn";
      OkBtn.Size = new System.Drawing.Size(78, 27);
      OkBtn.TabIndex = 1;
      OkBtn.Text = "OK";
      OkBtn.UseVisualStyleBackColor = true;
      // 
      // CancelBtn
      // 
      CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      CancelBtn.Location = new System.Drawing.Point(374, 505);
      CancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      CancelBtn.Name = "CancelBtn";
      CancelBtn.Size = new System.Drawing.Size(74, 25);
      CancelBtn.TabIndex = 2;
      CancelBtn.Text = "Cancel";
      CancelBtn.UseVisualStyleBackColor = true;
      // 
      // CombotantsFlow
      // 
      CombotantsFlow.AutoScroll = true;
      TableLayoutPanel.SetColumnSpan(CombotantsFlow, 3);
      CombotantsFlow.Dock = System.Windows.Forms.DockStyle.Fill;
      CombotantsFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      CombotantsFlow.Location = new System.Drawing.Point(3, 20);
      CombotantsFlow.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
      CombotantsFlow.Name = "CombotantsFlow";
      CombotantsFlow.Size = new System.Drawing.Size(446, 427);
      CombotantsFlow.TabIndex = 3;
      CombotantsFlow.WrapContents = false;
      // 
      // LabelTable
      // 
      LabelTable.ColumnCount = 6;
      TableLayoutPanel.SetColumnSpan(LabelTable, 3);
      LabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
      LabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      LabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      LabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      LabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      LabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
      LabelTable.Controls.Add(label2, 2, 0);
      LabelTable.Controls.Add(label3, 3, 0);
      LabelTable.Controls.Add(label4, 4, 0);
      LabelTable.Dock = System.Windows.Forms.DockStyle.Fill;
      LabelTable.Location = new System.Drawing.Point(0, 0);
      LabelTable.Margin = new System.Windows.Forms.Padding(0);
      LabelTable.Name = "LabelTable";
      LabelTable.RowCount = 1;
      LabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      LabelTable.Size = new System.Drawing.Size(452, 20);
      LabelTable.TabIndex = 7;
      // 
      // label2
      // 
      label2.Anchor = System.Windows.Forms.AnchorStyles.None;
      label2.AutoSize = true;
      label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
      label2.Location = new System.Drawing.Point(342, 4);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(22, 12);
      label2.TabIndex = 1;
      label2.Text = "X/2";
      // 
      // label3
      // 
      label3.Anchor = System.Windows.Forms.AnchorStyles.None;
      label3.AutoSize = true;
      label3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
      label3.Location = new System.Drawing.Point(377, 4);
      label3.Name = "label3";
      label3.Size = new System.Drawing.Size(12, 12);
      label3.TabIndex = 2;
      label3.Text = "X";
      // 
      // label4
      // 
      label4.Anchor = System.Windows.Forms.AnchorStyles.None;
      label4.AutoSize = true;
      label4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
      label4.Location = new System.Drawing.Point(404, 4);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(18, 12);
      label4.TabIndex = 3;
      label4.Text = "2X";
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 3;
      TableLayoutPanel.SetColumnSpan(tableLayoutPanel1, 3);
      tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
      tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
      tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      tableLayoutPanel1.Controls.Add(IsHeal, 1, 0);
      tableLayoutPanel1.Controls.Add(IsDmg, 0, 0);
      tableLayoutPanel1.Controls.Add(NoOverheal, 2, 0);
      tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      tableLayoutPanel1.Location = new System.Drawing.Point(0, 450);
      tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      tableLayoutPanel1.Size = new System.Drawing.Size(452, 23);
      tableLayoutPanel1.TabIndex = 4;
      // 
      // IsHeal
      // 
      IsHeal.AutoSize = true;
      IsHeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
      IsHeal.ForeColor = System.Drawing.Color.Green;
      IsHeal.Location = new System.Drawing.Point(82, 3);
      IsHeal.Name = "IsHeal";
      IsHeal.Size = new System.Drawing.Size(51, 17);
      IsHeal.TabIndex = 1;
      IsHeal.Text = "Heal";
      IsHeal.UseVisualStyleBackColor = true;
      IsHeal.CheckedChanged += IsHeal_CheckedChanged;
      // 
      // IsDmg
      // 
      IsDmg.AutoSize = true;
      IsDmg.Checked = true;
      IsDmg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
      IsDmg.ForeColor = System.Drawing.Color.DarkRed;
      IsDmg.Location = new System.Drawing.Point(3, 3);
      IsDmg.Name = "IsDmg";
      IsDmg.Size = new System.Drawing.Size(71, 17);
      IsDmg.TabIndex = 0;
      IsDmg.TabStop = true;
      IsDmg.Text = "Damage";
      IsDmg.UseVisualStyleBackColor = true;
      // 
      // NoOverheal
      // 
      NoOverheal.AutoSize = true;
      NoOverheal.Checked = true;
      NoOverheal.CheckState = System.Windows.Forms.CheckState.Checked;
      NoOverheal.Location = new System.Drawing.Point(140, 3);
      NoOverheal.Name = "NoOverheal";
      NoOverheal.Size = new System.Drawing.Size(90, 19);
      NoOverheal.TabIndex = 2;
      NoOverheal.TabStop = false;
      NoOverheal.Text = "No overheal";
      NoOverheal.UseVisualStyleBackColor = true;
      NoOverheal.Visible = false;
      // 
      // tableLayoutPanel2
      // 
      tableLayoutPanel2.ColumnCount = 3;
      TableLayoutPanel.SetColumnSpan(tableLayoutPanel2, 4);
      tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
      tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
      tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      tableLayoutPanel2.Controls.Add(DmgCounter, 0, 0);
      tableLayoutPanel2.Controls.Add(RollB, 1, 0);
      tableLayoutPanel2.Controls.Add(RollResultT, 2, 0);
      tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      tableLayoutPanel2.Location = new System.Drawing.Point(0, 473);
      tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      tableLayoutPanel2.Name = "tableLayoutPanel2";
      tableLayoutPanel2.RowCount = 1;
      tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      tableLayoutPanel2.Size = new System.Drawing.Size(452, 29);
      tableLayoutPanel2.TabIndex = 0;
      // 
      // DmgCounter
      // 
      DmgCounter.Dock = System.Windows.Forms.DockStyle.Fill;
      DmgCounter.Location = new System.Drawing.Point(4, 3);
      DmgCounter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      DmgCounter.Maximum = null;
      DmgCounter.Minimum = null;
      DmgCounter.Name = "DmgCounter";
      DmgCounter.Size = new System.Drawing.Size(71, 23);
      DmgCounter.TabIndex = 1;
      DmgCounter.Text = "0";
      DmgCounter.ToolTip = null;
      DmgCounter.Value = 0;
      // 
      // RollB
      // 
      RollB.Dock = System.Windows.Forms.DockStyle.Fill;
      RollB.Location = new System.Drawing.Point(82, 3);
      RollB.Name = "RollB";
      RollB.Size = new System.Drawing.Size(52, 23);
      RollB.TabIndex = 2;
      RollB.TabStop = false;
      RollB.Text = "Roll :";
      RollB.UseVisualStyleBackColor = true;
      RollB.Click += RollB_Click;
      // 
      // RollResultT
      // 
      RollResultT.BackColor = System.Drawing.SystemColors.Window;
      RollResultT.Dock = System.Windows.Forms.DockStyle.Fill;
      RollResultT.Location = new System.Drawing.Point(140, 3);
      RollResultT.Name = "RollResultT";
      RollResultT.ReadOnly = true;
      RollResultT.Size = new System.Drawing.Size(309, 23);
      RollResultT.TabIndex = 0;
      RollResultT.TabStop = false;
      // 
      // DmgDialog
      // 
      AcceptButton = OkBtn;
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      CancelButton = CancelBtn;
      ClientSize = new System.Drawing.Size(452, 533);
      Controls.Add(TableLayoutPanel);
      Margin = new System.Windows.Forms.Padding(2);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "DmgDialog";
      ShowIcon = false;
      ShowInTaskbar = false;
      StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      Text = "Deal Damage / Heal";
      Load += DMGDialog_Load;
      Resize += DmgDialog_Resize;
      TableLayoutPanel.ResumeLayout(false);
      LabelTable.ResumeLayout(false);
      LabelTable.PerformLayout();
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel1.PerformLayout();
      tableLayoutPanel2.ResumeLayout(false);
      tableLayoutPanel2.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.RadioButton IsDmg;
    private System.Windows.Forms.RadioButton IsHeal;
    private System.Windows.Forms.CheckBox NoOverheal;
    private DoubleBufferedFlow CombotantsFlow;
    private System.Windows.Forms.TableLayoutPanel LabelTable;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button OkBtn;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private CustomNumericInput DmgCounter;
    private System.Windows.Forms.Button RollB;
    private System.Windows.Forms.TextBox RollResultT;
    private System.Windows.Forms.Button CancelBtn;
  }
}