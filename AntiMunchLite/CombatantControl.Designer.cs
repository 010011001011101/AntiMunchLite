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

      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Обязательный метод для поддержки конструктора - не изменяйте 
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombatantControl));
      this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.CombatantName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.CurrentHp = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.MaxHp = new System.Windows.Forms.NumericUpDown();
      this.DelBtn = new System.Windows.Forms.Button();
      this.Initiative = new System.Windows.Forms.NumericUpDown();
      this.StatusLbl = new System.Windows.Forms.Label();
      this.DmgBtn = new System.Windows.Forms.Button();
      this.SubInitiative = new System.Windows.Forms.NumericUpDown();
      this.TableLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CurrentHp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.MaxHp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Initiative)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.SubInitiative)).BeginInit();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 10;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.TableLayoutPanel.Controls.Add(this.SubInitiative, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.CombatantName, 2, 0);
      this.TableLayoutPanel.Controls.Add(this.label1, 4, 0);
      this.TableLayoutPanel.Controls.Add(this.CurrentHp, 5, 0);
      this.TableLayoutPanel.Controls.Add(this.label2, 6, 0);
      this.TableLayoutPanel.Controls.Add(this.MaxHp, 7, 0);
      this.TableLayoutPanel.Controls.Add(this.DelBtn, 9, 0);
      this.TableLayoutPanel.Controls.Add(this.Initiative, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.StatusLbl, 8, 0);
      this.TableLayoutPanel.Controls.Add(this.DmgBtn, 3, 0);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 1;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(484, 32);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // CombatantName
      // 
      this.CombatantName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.CombatantName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.CombatantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CombatantName.Location = new System.Drawing.Point(98, 8);
      this.CombatantName.Name = "CombatantName";
      this.CombatantName.Size = new System.Drawing.Size(111, 16);
      this.CombatantName.TabIndex = 1;
      this.CombatantName.TextChanged += new System.EventHandler(this.CombatantName_TextChanged);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(242, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(28, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "HP :";
      // 
      // CurrentHp
      // 
      this.CurrentHp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.CurrentHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CurrentHp.Location = new System.Drawing.Point(276, 4);
      this.CurrentHp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.CurrentHp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.CurrentHp.Name = "CurrentHp";
      this.CurrentHp.Size = new System.Drawing.Size(44, 23);
      this.CurrentHp.TabIndex = 2;
      this.CurrentHp.ValueChanged += new System.EventHandler(this.CurrentHp_ValueChanged);
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(323, 9);
      this.label2.Margin = new System.Windows.Forms.Padding(0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(10, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "/";
      // 
      // MaxHp
      // 
      this.MaxHp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.MaxHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.MaxHp.Location = new System.Drawing.Point(336, 4);
      this.MaxHp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.MaxHp.Name = "MaxHp";
      this.MaxHp.Size = new System.Drawing.Size(39, 23);
      this.MaxHp.TabIndex = 3;
      this.MaxHp.ValueChanged += new System.EventHandler(this.MaxHp_ValueChanged);
      // 
      // DelBtn
      // 
      this.DelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DelBtn.Image = ((System.Drawing.Image)(resources.GetObject("DelBtn.Image")));
      this.DelBtn.Location = new System.Drawing.Point(459, 2);
      this.DelBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.DelBtn.Name = "DelBtn";
      this.DelBtn.Size = new System.Drawing.Size(24, 28);
      this.DelBtn.TabIndex = 6;
      this.DelBtn.TabStop = false;
      this.DelBtn.UseVisualStyleBackColor = true;
      // 
      // Initiative
      // 
      this.Initiative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.Initiative.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.Initiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Initiative.Location = new System.Drawing.Point(3, 6);
      this.Initiative.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.Initiative.Name = "Initiative";
      this.Initiative.Size = new System.Drawing.Size(44, 19);
      this.Initiative.TabIndex = 0;
      this.Initiative.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
      this.Initiative.ValueChanged += new System.EventHandler(this.Initiative_ValueChanged);
      // 
      // StatusLbl
      // 
      this.StatusLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.StatusLbl.AutoSize = true;
      this.StatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.StatusLbl.Location = new System.Drawing.Point(381, 7);
      this.StatusLbl.Name = "StatusLbl";
      this.StatusLbl.Size = new System.Drawing.Size(62, 17);
      this.StatusLbl.TabIndex = 8;
      this.StatusLbl.Text = "<status>";
      // 
      // DmgBtn
      // 
      this.DmgBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DmgBtn.Image = ((System.Drawing.Image)(resources.GetObject("DmgBtn.Image")));
      this.DmgBtn.Location = new System.Drawing.Point(213, 2);
      this.DmgBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.DmgBtn.Name = "DmgBtn";
      this.DmgBtn.Size = new System.Drawing.Size(23, 28);
      this.DmgBtn.TabIndex = 9;
      this.DmgBtn.TabStop = false;
      this.DmgBtn.UseVisualStyleBackColor = true;
      this.DmgBtn.Click += new System.EventHandler(this.DmgBtn_Click);
      // 
      // SubInitiative
      // 
      this.SubInitiative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.SubInitiative.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.SubInitiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SubInitiative.Location = new System.Drawing.Point(53, 6);
      this.SubInitiative.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.SubInitiative.Name = "SubInitiative";
      this.SubInitiative.Size = new System.Drawing.Size(39, 19);
      this.SubInitiative.TabIndex = 10;
      this.SubInitiative.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
      this.SubInitiative.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.SubInitiative.ValueChanged += new System.EventHandler(this.SubInitiative_ValueChanged);
      // 
      // CombatantControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.TableLayoutPanel);
      this.Name = "CombatantControl";
      this.Size = new System.Drawing.Size(484, 32);
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CurrentHp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.MaxHp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Initiative)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.SubInitiative)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.TextBox CombatantName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown CurrentHp;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown MaxHp;
    private System.Windows.Forms.Button DelBtn;
    private System.Windows.Forms.NumericUpDown Initiative;
    private System.Windows.Forms.Label StatusLbl;
    private System.Windows.Forms.Button DmgBtn;
    private System.Windows.Forms.NumericUpDown SubInitiative;
  }
}
