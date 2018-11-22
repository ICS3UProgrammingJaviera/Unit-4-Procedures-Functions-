namespace PassByRefJav
{
    partial class frmPassByRefJav
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
            this.lblEnterDec = new System.Windows.Forms.Label();
            this.lblUsersChoiceRound = new System.Windows.Forms.Label();
            this.btnRound = new System.Windows.Forms.Button();
            this.nudUsersChoiceDec = new System.Windows.Forms.NumericUpDown();
            this.txtUsersDec = new System.Windows.Forms.TextBox();
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudUsersChoiceDec)).BeginInit();
            this.mnuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterDec
            // 
            this.lblEnterDec.AutoSize = true;
            this.lblEnterDec.Font = new System.Drawing.Font("Adobe Arabic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDec.Location = new System.Drawing.Point(63, 81);
            this.lblEnterDec.Name = "lblEnterDec";
            this.lblEnterDec.Size = new System.Drawing.Size(220, 29);
            this.lblEnterDec.TabIndex = 0;
            this.lblEnterDec.Text = "Enter your decimal here:";
            // 
            // lblUsersChoiceRound
            // 
            this.lblUsersChoiceRound.AutoSize = true;
            this.lblUsersChoiceRound.Font = new System.Drawing.Font("Adobe Arabic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersChoiceRound.Location = new System.Drawing.Point(12, 152);
            this.lblUsersChoiceRound.Name = "lblUsersChoiceRound";
            this.lblUsersChoiceRound.Size = new System.Drawing.Size(462, 29);
            this.lblUsersChoiceRound.TabIndex = 1;
            this.lblUsersChoiceRound.Text = "How mnay places do you want to round your decimal?";
            // 
            // btnRound
            // 
            this.btnRound.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRound.Font = new System.Drawing.Font("Adobe Arabic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRound.Location = new System.Drawing.Point(277, 224);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(112, 45);
            this.btnRound.TabIndex = 2;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = false;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // nudUsersChoiceDec
            // 
            this.nudUsersChoiceDec.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudUsersChoiceDec.Location = new System.Drawing.Point(480, 154);
            this.nudUsersChoiceDec.Name = "nudUsersChoiceDec";
            this.nudUsersChoiceDec.Size = new System.Drawing.Size(120, 30);
            this.nudUsersChoiceDec.TabIndex = 3;
            // 
            // txtUsersDec
            // 
            this.txtUsersDec.Font = new System.Drawing.Font("Adobe Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsersDec.Location = new System.Drawing.Point(289, 85);
            this.txtUsersDec.Name = "txtUsersDec";
            this.txtUsersDec.Size = new System.Drawing.Size(100, 28);
            this.txtUsersDec.TabIndex = 4;
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(674, 34);
            this.mnuFile.TabIndex = 5;
            this.mnuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Adobe Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mniExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 30);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmPassByRefJav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(674, 336);
            this.Controls.Add(this.txtUsersDec);
            this.Controls.Add(this.nudUsersChoiceDec);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.lblUsersChoiceRound);
            this.Controls.Add(this.lblEnterDec);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmPassByRefJav";
            this.Text = "Rounding Decimals with Pass By Refrence by Javiera Diaz";
            this.Load += new System.EventHandler(this.frmPassByRefJav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUsersChoiceDec)).EndInit();
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterDec;
        private System.Windows.Forms.Label lblUsersChoiceRound;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.NumericUpDown nudUsersChoiceDec;
        private System.Windows.Forms.TextBox txtUsersDec;
        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

