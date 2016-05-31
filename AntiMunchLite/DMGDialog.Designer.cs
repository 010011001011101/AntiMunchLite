namespace AntiMunchLite
{
  partial class DMGDialog
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
      this.DmgCounter = new System.Windows.Forms.NumericUpDown();
      this.OkBtn = new System.Windows.Forms.Button();
      this.CancelBtn = new System.Windows.Forms.Button();
      this.TableLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DmgCounter)).BeginInit();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 2;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
      this.TableLayoutPanel.Controls.Add(this.DmgCounter, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.OkBtn, 0, 1);
      this.TableLayoutPanel.Controls.Add(this.CancelBtn, 1, 1);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 2;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(133, 51);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // DmgCounter
      // 
      this.TableLayoutPanel.SetColumnSpan(this.DmgCounter, 2);
      this.DmgCounter.Location = new System.Drawing.Point(2, 2);
      this.DmgCounter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.DmgCounter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.DmgCounter.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
      this.DmgCounter.Name = "DmgCounter";
      this.DmgCounter.Size = new System.Drawing.Size(128, 20);
      this.DmgCounter.TabIndex = 0;
      // 
      // OkBtn
      // 
      this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OkBtn.Location = new System.Drawing.Point(14, 23);
      this.OkBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.OkBtn.Name = "OkBtn";
      this.OkBtn.Size = new System.Drawing.Size(56, 23);
      this.OkBtn.TabIndex = 1;
      this.OkBtn.Text = "Ok";
      this.OkBtn.UseVisualStyleBackColor = true;
      // 
      // CancelBtn
      // 
      this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelBtn.Location = new System.Drawing.Point(74, 23);
      this.CancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(56, 23);
      this.CancelBtn.TabIndex = 2;
      this.CancelBtn.Text = "Отмена";
      this.CancelBtn.UseVisualStyleBackColor = true;
      // 
      // DMGDialog
      // 
      this.AcceptButton = this.OkBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CancelBtn;
      this.ClientSize = new System.Drawing.Size(133, 51);
      this.Controls.Add(this.TableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DMGDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Нанести урон";
      this.Load += new System.EventHandler(this.DMGDialog_Load);
      this.TableLayoutPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DmgCounter)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.Button OkBtn;
    private System.Windows.Forms.Button CancelBtn;
    public System.Windows.Forms.NumericUpDown DmgCounter;
  }
}