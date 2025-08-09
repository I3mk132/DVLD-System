namespace Presentation_Layer.ApplicationForms.LicensesForms
{
    partial class frmLicenseInfo
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
            this.lblTestAppointments = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ucLicenseCard1 = new Presentation_Layer.UserControls.LicenseUserControls.ucLicenseCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestAppointments
            // 
            this.lblTestAppointments.AutoSize = true;
            this.lblTestAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestAppointments.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTestAppointments.Location = new System.Drawing.Point(274, 187);
            this.lblTestAppointments.Name = "lblTestAppointments";
            this.lblTestAppointments.Size = new System.Drawing.Size(260, 31);
            this.lblTestAppointments.TabIndex = 141;
            this.lblTestAppointments.Text = "Driver License Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.License1;
            this.pictureBox1.Location = new System.Drawing.Point(302, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 140;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(658, 574);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 139;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucLicenseCard1
            // 
            this.ucLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ucLicenseCard1.Location = new System.Drawing.Point(12, 235);
            this.ucLicenseCard1.Name = "ucLicenseCard1";
            this.ucLicenseCard1.Padding = new System.Windows.Forms.Padding(5);
            this.ucLicenseCard1.Size = new System.Drawing.Size(780, 333);
            this.ucLicenseCard1.TabIndex = 142;
            // 
            // frmLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(804, 622);
            this.Controls.Add(this.ucLicenseCard1);
            this.Controls.Add(this.lblTestAppointments);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Info";
            this.Load += new System.EventHandler(this.frmLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTestAppointments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.LicenseUserControls.ucLicenseCard ucLicenseCard1;
    }
}