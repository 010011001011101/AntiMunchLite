namespace AntiMunchLite
{
  partial class SaveDialog
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
      this.SaveFileName = new System.Windows.Forms.TextBox();
      this.TableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 2;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
      this.TableLayoutPanel.Controls.Add(this.OkBtn, 0, 1);
      this.TableLayoutPanel.Controls.Add(this.CancelBtn, 1, 1);
      this.TableLayoutPanel.Controls.Add(this.SaveFileName, 0, 0);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 2;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(208, 56);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // OkBtn
      // 
      this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OkBtn.Location = new System.Drawing.Point(89, 28);
      this.OkBtn.Margin = new System.Windows.Forms.Padding(2);
      this.OkBtn.Name = "OkBtn";
      this.OkBtn.Size = new System.Drawing.Size(56, 23);
      this.OkBtn.TabIndex = 1;
      this.OkBtn.Text = "Ok";
      this.OkBtn.UseVisualStyleBackColor = true;
      // 
      // CancelBtn
      // 
      this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelBtn.Location = new System.Drawing.Point(149, 28);
      this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(56, 23);
      this.CancelBtn.TabIndex = 2;
      this.CancelBtn.Text = "Отмена";
      this.CancelBtn.UseVisualStyleBackColor = true;
      // 
      // SaveFileName
      // 
      this.TableLayoutPanel.SetColumnSpan(this.SaveFileName, 2);
      this.SaveFileName.Dock = System.Windows.Forms.DockStyle.Top;
      this.SaveFileName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SaveFileName.Location = new System.Drawing.Point(3, 3);
      this.SaveFileName.Name = "SaveFileName";
      this.SaveFileName.Size = new System.Drawing.Size(202, 23);
      this.SaveFileName.TabIndex = 3;
      // 
      // SaveDialog
      // 
      this.AcceptButton = this.OkBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CancelBtn;
      this.ClientSize = new System.Drawing.Size(208, 56);
      this.Controls.Add(this.TableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SaveDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Сохранить как...";
      this.Load += new System.EventHandler(this.SaveDialog_Load);
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.Button OkBtn;
    private System.Windows.Forms.Button CancelBtn;
    private System.Windows.Forms.TextBox SaveFileName;
  }
}