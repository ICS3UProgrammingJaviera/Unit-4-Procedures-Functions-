namespace ConvertToFaren_Jav_
{
    partial class frmConvertToFarenJav
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
            this.lblStatement = new System.Windows.Forms.Label();
            this.txtUsersCelsius = new System.Windows.Forms.TextBox();
            this.btnConvertTemp = new System.Windows.Forms.Button();
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement.Location = new System.Drawing.Point(123, 106);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(386, 18);
            this.lblStatement.TabIndex = 0;
            this.lblStatement.Text = "Enter the temparature in degreees celsius:";
            // 
            // txtUsersCelsius
            // 
            this.txtUsersCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsersCelsius.Location = new System.Drawing.Point(521, 102);
            this.txtUsersCelsius.Name = "txtUsersCelsius";
            this.txtUsersCelsius.Size = new System.Drawing.Size(100, 22);
            this.txtUsersCelsius.TabIndex = 1;
            // 
            // btnConvertTemp
            // 
            this.btnConvertTemp.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertTemp.Location = new System.Drawing.Point(380, 185);
            this.btnConvertTemp.Name = "btnConvertTemp";
            this.btnConvertTemp.Size = new System.Drawing.Size(196, 58);
            this.btnConvertTemp.TabIndex = 4;
            this.btnConvertTemp.Text = "Convert Temperature to Farenheit";
            this.btnConvertTemp.UseVisualStyleBackColor = true;
            this.btnConvertTemp.Click += new System.EventHandler(this.button1_Click);
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(633, 24);
            this.mnuFile.TabIndex = 5;
            this.mnuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConvertToFaren_Jav_.Properties.Resources.celsius;
            this.pictureBox1.Location = new System.Drawing.Point(0, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmConvertToFarenJav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(633, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConvertTemp);
            this.Controls.Add(this.txtUsersCelsius);
            this.Controls.Add(this.lblStatement);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmConvertToFarenJav";
            this.Text = "Convert to Farenheit by Javiera Diaz";
            this.Load += new System.EventHandler(this.frmConvertToFarenJav_Load);
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.TextBox txtUsersCelsius;
        private System.Windows.Forms.Button btnConvertTemp;
        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

