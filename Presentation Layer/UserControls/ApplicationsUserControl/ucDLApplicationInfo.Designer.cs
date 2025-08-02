namespace Presentation_Layer.UserControls.ApplicationsUserControl
{
    partial class ucDLApplicationInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblShowLicense = new System.Windows.Forms.LinkLabel();
            this.lblPassedTestValue = new System.Windows.Forms.Label();
            this.lblLicenseValue = new System.Windows.Forms.Label();
            this.pbIsActive = new System.Windows.Forms.PictureBox();
            this.lblDLAppIDTitle = new System.Windows.Forms.Label();
            this.lblPassedTestTitle = new System.Windows.Forms.Label();
            this.pbUserNo = new System.Windows.Forms.PictureBox();
            this.lblDLAppIDValue = new System.Windows.Forms.Label();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.lblAppliedLicenseTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblShowLicense);
            this.groupBox1.Controls.Add(this.lblPassedTestValue);
            this.groupBox1.Controls.Add(this.lblLicenseValue);
            this.groupBox1.Controls.Add(this.pbIsActive);
            this.groupBox1.Controls.Add(this.lblDLAppIDTitle);
            this.groupBox1.Controls.Add(this.lblPassedTestTitle);
            this.groupBox1.Controls.Add(this.pbUserNo);
            this.groupBox1.Controls.Add(this.lblDLAppIDValue);
            this.groupBox1.Controls.Add(this.pbUsername);
            this.groupBox1.Controls.Add(this.lblAppliedLicenseTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License Application Info";
            // 
            // lblShowLicense
            // 
            this.lblShowLicense.AutoSize = true;
            this.lblShowLicense.Enabled = false;
            this.lblShowLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblShowLicense.Location = new System.Drawing.Point(20, 68);
            this.lblShowLicense.Name = "lblShowLicense";
            this.lblShowLicense.Size = new System.Drawing.Size(164, 24);
            this.lblShowLicense.TabIndex = 103;
            this.lblShowLicense.TabStop = true;
            this.lblShowLicense.Text = "Show License Info";
            this.lblShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicense_LinkClicked);
            // 
            // lblPassedTestValue
            // 
            this.lblPassedTestValue.AutoSize = true;
            this.lblPassedTestValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassedTestValue.ForeColor = System.Drawing.Color.Black;
            this.lblPassedTestValue.Location = new System.Drawing.Point(440, 65);
            this.lblPassedTestValue.Name = "lblPassedTestValue";
            this.lblPassedTestValue.Size = new System.Drawing.Size(40, 24);
            this.lblPassedTestValue.TabIndex = 101;
            this.lblPassedTestValue.Text = "???";
            // 
            // lblLicenseValue
            // 
            this.lblLicenseValue.AutoSize = true;
            this.lblLicenseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseValue.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseValue.Location = new System.Drawing.Point(440, 23);
            this.lblLicenseValue.Name = "lblLicenseValue";
            this.lblLicenseValue.Size = new System.Drawing.Size(40, 24);
            this.lblLicenseValue.TabIndex = 102;
            this.lblLicenseValue.Text = "???";
            // 
            // pbIsActive
            // 
            this.pbIsActive.Image = global::Presentation_Layer.Properties.Resources.Key;
            this.pbIsActive.Location = new System.Drawing.Point(411, 63);
            this.pbIsActive.Name = "pbIsActive";
            this.pbIsActive.Size = new System.Drawing.Size(25, 25);
            this.pbIsActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIsActive.TabIndex = 98;
            this.pbIsActive.TabStop = false;
            // 
            // lblDLAppIDTitle
            // 
            this.lblDLAppIDTitle.AutoSize = true;
            this.lblDLAppIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAppIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblDLAppIDTitle.Location = new System.Drawing.Point(20, 28);
            this.lblDLAppIDTitle.Name = "lblDLAppIDTitle";
            this.lblDLAppIDTitle.Size = new System.Drawing.Size(103, 20);
            this.lblDLAppIDTitle.TabIndex = 99;
            this.lblDLAppIDTitle.Text = "D.L.App ID:";
            // 
            // lblPassedTestTitle
            // 
            this.lblPassedTestTitle.AutoSize = true;
            this.lblPassedTestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassedTestTitle.ForeColor = System.Drawing.Color.Black;
            this.lblPassedTestTitle.Location = new System.Drawing.Point(279, 68);
            this.lblPassedTestTitle.Name = "lblPassedTestTitle";
            this.lblPassedTestTitle.Size = new System.Drawing.Size(122, 20);
            this.lblPassedTestTitle.TabIndex = 95;
            this.lblPassedTestTitle.Text = "Passed Tests:";
            // 
            // pbUserNo
            // 
            this.pbUserNo.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pbUserNo.Location = new System.Drawing.Point(129, 25);
            this.pbUserNo.Name = "pbUserNo";
            this.pbUserNo.Size = new System.Drawing.Size(25, 25);
            this.pbUserNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserNo.TabIndex = 97;
            this.pbUserNo.TabStop = false;
            // 
            // lblDLAppIDValue
            // 
            this.lblDLAppIDValue.AutoSize = true;
            this.lblDLAppIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAppIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblDLAppIDValue.Location = new System.Drawing.Point(158, 24);
            this.lblDLAppIDValue.Name = "lblDLAppIDValue";
            this.lblDLAppIDValue.Size = new System.Drawing.Size(40, 24);
            this.lblDLAppIDValue.TabIndex = 100;
            this.lblDLAppIDValue.Text = "???";
            // 
            // pbUsername
            // 
            this.pbUsername.Image = global::Presentation_Layer.Properties.Resources.License_pink;
            this.pbUsername.Location = new System.Drawing.Point(411, 25);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(25, 25);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsername.TabIndex = 96;
            this.pbUsername.TabStop = false;
            // 
            // lblAppliedLicenseTitle
            // 
            this.lblAppliedLicenseTitle.AutoSize = true;
            this.lblAppliedLicenseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppliedLicenseTitle.ForeColor = System.Drawing.Color.Black;
            this.lblAppliedLicenseTitle.Location = new System.Drawing.Point(259, 28);
            this.lblAppliedLicenseTitle.Name = "lblAppliedLicenseTitle";
            this.lblAppliedLicenseTitle.Size = new System.Drawing.Size(146, 20);
            this.lblAppliedLicenseTitle.TabIndex = 94;
            this.lblAppliedLicenseTitle.Text = "Applied License: ";
            // 
            // ucDLApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucDLApplicationInfo";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(659, 126);
            this.Load += new System.EventHandler(this.ucDLApplicationInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPassedTestValue;
        private System.Windows.Forms.Label lblLicenseValue;
        private System.Windows.Forms.PictureBox pbIsActive;
        private System.Windows.Forms.Label lblDLAppIDTitle;
        private System.Windows.Forms.Label lblPassedTestTitle;
        private System.Windows.Forms.PictureBox pbUserNo;
        private System.Windows.Forms.Label lblDLAppIDValue;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.Label lblAppliedLicenseTitle;
        private System.Windows.Forms.LinkLabel lblShowLicense;
    }
}
