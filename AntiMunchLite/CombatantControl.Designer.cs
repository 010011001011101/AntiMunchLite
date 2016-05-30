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
      this.TableLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CurrentHp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.MaxHp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Initiative)).BeginInit();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 9;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.TableLayoutPanel.Controls.Add(this.CombatantName, 1, 0);
      this.TableLayoutPanel.Controls.Add(this.label1, 3, 0);
      this.TableLayoutPanel.Controls.Add(this.CurrentHp, 4, 0);
      this.TableLayoutPanel.Controls.Add(this.label2, 5, 0);
      this.TableLayoutPanel.Controls.Add(this.MaxHp, 6, 0);
      this.TableLayoutPanel.Controls.Add(this.DelBtn, 8, 0);
      this.TableLayoutPanel.Controls.Add(this.Initiative, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.StatusLbl, 7, 0);
      this.TableLayoutPanel.Controls.Add(this.DmgBtn, 2, 0);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 1;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(645, 39);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // CombatantName
      // 
      this.CombatantName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.CombatantName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.CombatantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CombatantName.Location = new System.Drawing.Point(85, 10);
      this.CombatantName.Margin = new System.Windows.Forms.Padding(4);
      this.CombatantName.Name = "CombatantName";
      this.CombatantName.Size = new System.Drawing.Size(195, 19);
      this.CombatantName.TabIndex = 1;
      this.CombatantName.TextChanged += new System.EventHandler(this.CombatantName_TextChanged);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(326, 11);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "HP :";
      // 
      // CurrentHp
      // 
      this.CurrentHp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.CurrentHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CurrentHp.Location = new System.Drawing.Point(369, 6);
      this.CurrentHp.Margin = new System.Windows.Forms.Padding(4);
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
      this.CurrentHp.Size = new System.Drawing.Size(59, 26);
      this.CurrentHp.TabIndex = 2;
      this.CurrentHp.ValueChanged += new System.EventHandler(this.CurrentHp_ValueChanged);
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(432, 11);
      this.label2.Margin = new System.Windows.Forms.Padding(0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(12, 17);
      this.label2.TabIndex = 4;
      this.label2.Text = "/";
      // 
      // MaxHp
      // 
      this.MaxHp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.MaxHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.MaxHp.Location = new System.Drawing.Point(449, 6);
      this.MaxHp.Margin = new System.Windows.Forms.Padding(4);
      this.MaxHp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.MaxHp.Name = "MaxHp";
      this.MaxHp.Size = new System.Drawing.Size(52, 26);
      this.MaxHp.TabIndex = 3;
      this.MaxHp.ValueChanged += new System.EventHandler(this.MaxHp_ValueChanged);
      // 
      // DelBtn
      // 
      this.DelBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.DelBtn.Image = ((System.Drawing.Image)(resources.GetObject("DelBtn.Image")));
      this.DelBtn.Location = new System.Drawing.Point(616, 7);
      this.DelBtn.Margin = new System.Windows.Forms.Padding(4);
      this.DelBtn.Name = "DelBtn";
      this.DelBtn.Size = new System.Drawing.Size(25, 25);
      this.DelBtn.TabIndex = 6;
      this.DelBtn.TabStop = false;
      this.DelBtn.UseVisualStyleBackColor = true;
      // 
      // Initiative
      // 
      this.Initiative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.Initiative.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.Initiative.DecimalPlaces = 1;
      this.Initiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Initiative.Location = new System.Drawing.Point(4, 8);
      this.Initiative.Margin = new System.Windows.Forms.Padding(4);
      this.Initiative.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.Initiative.Name = "Initiative";
      this.Initiative.Size = new System.Drawing.Size(73, 22);
      this.Initiative.TabIndex = 0;
      this.Initiative.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
      this.Initiative.ValueChanged += new System.EventHandler(this.Initiative_ValueChanged);
      // 
      // StatusLbl
      // 
      this.StatusLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.StatusLbl.AutoSize = true;
      this.StatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.StatusLbl.Location = new System.Drawing.Point(509, 9);
      this.StatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.StatusLbl.Name = "StatusLbl";
      this.StatusLbl.Size = new System.Drawing.Size(75, 20);
      this.StatusLbl.TabIndex = 8;
      this.StatusLbl.Text = "<status>";
      // 
      // DmgBtn
      // 
      this.DmgBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.DmgBtn.Image = ((System.Drawing.Image)(resources.GetObject("DmgBtn.Image")));
      this.DmgBtn.Location = new System.Drawing.Point(288, 7);
      this.DmgBtn.Margin = new System.Windows.Forms.Padding(4);
      this.DmgBtn.Name = "DmgBtn";
      this.DmgBtn.Size = new System.Drawing.Size(25, 25);
      this.DmgBtn.TabIndex = 9;
      this.DmgBtn.TabStop = false;
      this.DmgBtn.UseVisualStyleBackColor = true;
      this.DmgBtn.Click += new System.EventHandler(this.DmgBtn_Click);
      // 
      // CombatantControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.TableLayoutPanel);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "CombatantControl";
      this.Size = new System.Drawing.Size(645, 39);
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CurrentHp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.MaxHp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Initiative)).EndInit();
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
  }
}
