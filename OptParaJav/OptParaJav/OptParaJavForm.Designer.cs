namespace OptParaJav
{
    partial class frmOptParaJav
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
            this.lblEnterAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEnterAddress = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblUnitNum = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtUnitNum = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterAddress
            // 
            this.lblEnterAddress.AutoSize = true;
            this.lblEnterAddress.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnterAddress.Location = new System.Drawing.Point(22, 83);
            this.lblEnterAddress.Name = "lblEnterAddress";
            this.lblEnterAddress.Size = new System.Drawing.Size(108, 31);
            this.lblEnterAddress.TabIndex = 0;
            this.lblEnterAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(136, 83);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(164, 24);
            this.txtAddress.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnEnterAddress
            // 
            this.btnEnterAddress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnterAddress.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnterAddress.Location = new System.Drawing.Point(289, 339);
            this.btnEnterAddress.Name = "btnEnterAddress";
            this.btnEnterAddress.Size = new System.Drawing.Size(93, 43);
            this.btnEnterAddress.TabIndex = 3;
            this.btnEnterAddress.Text = "Enter";
            this.btnEnterAddress.UseVisualStyleBackColor = false;
            this.btnEnterAddress.Click += new System.EventHandler(this.btnEnterAddress_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(51, 171);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(69, 31);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // lblUnitNum
            // 
            this.lblUnitNum.AutoSize = true;
            this.lblUnitNum.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUnitNum.Location = new System.Drawing.Point(343, 171);
            this.lblUnitNum.Name = "lblUnitNum";
            this.lblUnitNum.Size = new System.Drawing.Size(100, 31);
            this.lblUnitNum.TabIndex = 5;
            this.lblUnitNum.Text = "Unit #:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPostalCode.Location = new System.Drawing.Point(164, 258);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(157, 31);
            this.lblPostalCode.TabIndex = 6;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProvince.Location = new System.Drawing.Point(376, 83);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(115, 31);
            this.lblProvince.TabIndex = 7;
            this.lblProvince.Text = "Province:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(126, 171);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(164, 24);
            this.txtCity.TabIndex = 8;
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvince.Location = new System.Drawing.Point(497, 83);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(164, 24);
            this.txtProvince.TabIndex = 9;
            // 
            // txtUnitNum
            // 
            this.txtUnitNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitNum.Location = new System.Drawing.Point(449, 171);
            this.txtUnitNum.Name = "txtUnitNum";
            this.txtUnitNum.Size = new System.Drawing.Size(164, 24);
            this.txtUnitNum.TabIndex = 10;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.Location = new System.Drawing.Point(327, 258);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(164, 24);
            this.txtPostalCode.TabIndex = 11;
            // 
            // frmOptParaJav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(684, 415);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtUnitNum);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblUnitNum);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnEnterAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblEnterAddress);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOptParaJav";
            this.Text = "Optonal Parameters by Javiera Diaz";
            this.Load += new System.EventHandler(this.frmOptParaJav_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnEnterAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblUnitNum;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtUnitNum;
        private System.Windows.Forms.TextBox txtPostalCode;
    }
}

