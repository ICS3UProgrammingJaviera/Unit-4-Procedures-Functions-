namespace PercentageProgJav
{
    partial class frmPercentageProgJav
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
            this.btnCalculatePercent = new System.Windows.Forms.Button();
            this.lblEnterGrade = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtUsersGrade = new System.Windows.Forms.TextBox();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculatePercent
            // 
            this.btnCalculatePercent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculatePercent.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePercent.Location = new System.Drawing.Point(291, 134);
            this.btnCalculatePercent.Name = "btnCalculatePercent";
            this.btnCalculatePercent.Size = new System.Drawing.Size(96, 41);
            this.btnCalculatePercent.TabIndex = 0;
            this.btnCalculatePercent.Text = "Enter";
            this.btnCalculatePercent.UseVisualStyleBackColor = false;
            this.btnCalculatePercent.Click += new System.EventHandler(this.btnCalculatePercent_Click);
            // 
            // lblEnterGrade
            // 
            this.lblEnterGrade.AutoSize = true;
            this.lblEnterGrade.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterGrade.Location = new System.Drawing.Point(42, 40);
            this.lblEnterGrade.Name = "lblEnterGrade";
            this.lblEnterGrade.Size = new System.Drawing.Size(274, 21);
            this.lblEnterGrade.TabIndex = 1;
            this.lblEnterGrade.Text = "Enter your grade here:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtUsersGrade
            // 
            this.txtUsersGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsersGrade.Location = new System.Drawing.Point(322, 40);
            this.txtUsersGrade.Name = "txtUsersGrade";
            this.txtUsersGrade.Size = new System.Drawing.Size(100, 24);
            this.txtUsersGrade.TabIndex = 3;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PercentageProgJav.Properties.Resources.perc;
            this.pictureBox1.Location = new System.Drawing.Point(25, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmPercentageProgJav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(467, 282);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUsersGrade);
            this.Controls.Add(this.lblEnterGrade);
            this.Controls.Add(this.btnCalculatePercent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPercentageProgJav";
            this.Text = "Percentage Program by Javiera Diaz";
            this.Load += new System.EventHandler(this.frmPercentageProgJav_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculatePercent;
        private System.Windows.Forms.Label lblEnterGrade;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.TextBox txtUsersGrade;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

