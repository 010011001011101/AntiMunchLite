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
      this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.OkBtn = new System.Windows.Forms.Button();
      this.CancelBtn = new System.Windows.Forms.Button();
      this.Combotants = new System.Windows.Forms.CheckedListBox();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.IsDmg = new System.Windows.Forms.RadioButton();
      this.IsHeal = new System.Windows.Forms.RadioButton();
      this.NoOverheal = new System.Windows.Forms.CheckBox();
      this.DmgCounter = new AntiMunchLite.BaseControls.CustomNumericInput();
      this.TableLayoutPanel.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 4;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.TableLayoutPanel.Controls.Add(this.OkBtn, 2, 3);
      this.TableLayoutPanel.Controls.Add(this.CancelBtn, 3, 3);
      this.TableLayoutPanel.Controls.Add(this.Combotants, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 1, 1);
      this.TableLayoutPanel.Controls.Add(this.NoOverheal, 0, 2);
      this.TableLayoutPanel.Controls.Add(this.DmgCounter, 0, 1);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 4;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(284, 262);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // OkBtn
      // 
      this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.OkBtn.Location = new System.Drawing.Point(146, 237);
      this.OkBtn.Margin = new System.Windows.Forms.Padding(2);
      this.OkBtn.Name = "OkBtn";
      this.OkBtn.Size = new System.Drawing.Size(66, 23);
      this.OkBtn.TabIndex = 4;
      this.OkBtn.Text = "OK";
      this.OkBtn.UseVisualStyleBackColor = true;
      // 
      // CancelBtn
      // 
      this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CancelBtn.Location = new System.Drawing.Point(217, 238);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(64, 21);
      this.CancelBtn.TabIndex = 5;
      this.CancelBtn.Text = "Cancel";
      this.CancelBtn.UseVisualStyleBackColor = true;
      // 
      // Combotants
      // 
      this.Combotants.CheckOnClick = true;
      this.TableLayoutPanel.SetColumnSpan(this.Combotants, 4);
      this.Combotants.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Combotants.FormattingEnabled = true;
      this.Combotants.Location = new System.Drawing.Point(3, 3);
      this.Combotants.Name = "Combotants";
      this.Combotants.Size = new System.Drawing.Size(278, 184);
      this.Combotants.TabIndex = 0;
      this.Combotants.TabStop = false;
      // 
      // flowLayoutPanel1
      // 
      this.TableLayoutPanel.SetColumnSpan(this.flowLayoutPanel1, 3);
      this.flowLayoutPanel1.Controls.Add(this.IsDmg);
      this.flowLayoutPanel1.Controls.Add(this.IsHeal);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(71, 190);
      this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(213, 23);
      this.flowLayoutPanel1.TabIndex = 2;
      // 
      // IsDmg
      // 
      this.IsDmg.AutoSize = true;
      this.IsDmg.Checked = true;
      this.IsDmg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.IsDmg.ForeColor = System.Drawing.Color.DarkRed;
      this.IsDmg.Location = new System.Drawing.Point(3, 3);
      this.IsDmg.Name = "IsDmg";
      this.IsDmg.Size = new System.Drawing.Size(71, 17);
      this.IsDmg.TabIndex = 0;
      this.IsDmg.TabStop = true;
      this.IsDmg.Text = "Damage";
      this.IsDmg.UseVisualStyleBackColor = true;
      // 
      // IsHeal
      // 
      this.IsHeal.AutoSize = true;
      this.IsHeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.IsHeal.ForeColor = System.Drawing.Color.Green;
      this.IsHeal.Location = new System.Drawing.Point(80, 3);
      this.IsHeal.Name = "IsHeal";
      this.IsHeal.Size = new System.Drawing.Size(51, 17);
      this.IsHeal.TabIndex = 1;
      this.IsHeal.Text = "Heal";
      this.IsHeal.UseVisualStyleBackColor = true;
      // 
      // NoOverheal
      // 
      this.NoOverheal.AutoSize = true;
      this.NoOverheal.Checked = true;
      this.NoOverheal.CheckState = System.Windows.Forms.CheckState.Checked;
      this.TableLayoutPanel.SetColumnSpan(this.NoOverheal, 4);
      this.NoOverheal.Location = new System.Drawing.Point(3, 216);
      this.NoOverheal.Name = "NoOverheal";
      this.NoOverheal.Size = new System.Drawing.Size(84, 16);
      this.NoOverheal.TabIndex = 3;
      this.NoOverheal.Text = "No overheal";
      this.NoOverheal.UseVisualStyleBackColor = true;
      // 
      // DmgCounter
      // 
      this.DmgCounter.Location = new System.Drawing.Point(3, 193);
      this.DmgCounter.Maximum = null;
      this.DmgCounter.Minimum = null;
      this.DmgCounter.Name = "DmgCounter";
      this.DmgCounter.Size = new System.Drawing.Size(65, 20);
      this.DmgCounter.TabIndex = 1;
      this.DmgCounter.Text = "0";
      this.DmgCounter.ToolTip = null;
      this.DmgCounter.Value = 0;
      // 
      // DmgDialog
      // 
      this.AcceptButton = this.OkBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CancelBtn;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.TableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DmgDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Deal Damage / Heal";
      this.Load += new System.EventHandler(this.DMGDialog_Load);
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.Button OkBtn;
    private System.Windows.Forms.Button CancelBtn;
    private System.Windows.Forms.CheckedListBox Combotants;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.RadioButton IsDmg;
    private System.Windows.Forms.RadioButton IsHeal;
    private System.Windows.Forms.CheckBox NoOverheal;
    private BaseControls.CustomNumericInput DmgCounter;
  }
}