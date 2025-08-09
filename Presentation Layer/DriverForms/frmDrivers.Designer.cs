namespace Presentation_Layer.DriverForms
{
    partial class frmDrivers
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
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucDriversList1 = new Presentation_Layer.UserControls.DriverUserControls.ucDriversList();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.Color.Firebrick;
            this.lblManageUsers.Location = new System.Drawing.Point(324, 183);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(219, 31);
            this.lblManageUsers.TabIndex = 11;
            this.lblManageUsers.Text = "Manage Drivers";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(729, 586);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.Drivers;
            this.pictureBox1.Location = new System.Drawing.Point(339, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ucDriversList1
            // 
            this.ucDriversList1.BackColor = System.Drawing.Color.Transparent;
            this.ucDriversList1.Location = new System.Drawing.Point(12, 214);
            this.ucDriversList1.Name = "ucDriversList1";
            this.ucDriversList1.Size = new System.Drawing.Size(851, 391);
            this.ucDriversList1.TabIndex = 14;
            // 
            // frmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(875, 633);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucDriversList1);
            this.Controls.Add(this.lblManageUsers);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDrivers";
            this.Text = "frmDrivers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.DriverUserControls.ucDriversList ucDriversList1;
    }
}