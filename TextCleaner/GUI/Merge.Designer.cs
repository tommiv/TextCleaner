namespace TextCleaner.GUI
{
    partial class Merge
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
            this.btnRun = new System.Windows.Forms.Button();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TxtAbstractAnchor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowsePath = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(214, 111);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(12, 12);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.ReadOnly = true;
            this.TxtPath.Size = new System.Drawing.Size(368, 20);
            this.TxtPath.TabIndex = 1;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(386, 10);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 2;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TxtAbstractAnchor
            // 
            this.TxtAbstractAnchor.Location = new System.Drawing.Point(12, 52);
            this.TxtAbstractAnchor.Name = "TxtAbstractAnchor";
            this.TxtAbstractAnchor.Size = new System.Drawing.Size(368, 20);
            this.TxtAbstractAnchor.TabIndex = 3;
            this.TxtAbstractAnchor.Text = "###";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Abstract anchor";
            // 
            // BrowsePath
            // 
            this.BrowsePath.ShowNewFolderButton = false;
            // 
            // Merge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 145);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAbstractAnchor);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.btnRun);
            this.Name = "Merge";
            this.Text = "Merge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TxtAbstractAnchor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog BrowsePath;
    }
}