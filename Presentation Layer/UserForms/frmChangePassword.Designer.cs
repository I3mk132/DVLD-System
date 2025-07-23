namespace Presentation_Layer.UserForms
{
    partial class frmChangePassword
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
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPasswordTitle = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordTitle = new System.Windows.Forms.Label();
            this.lblCurrentPasswordTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbKey3 = new System.Windows.Forms.PictureBox();
            this.pbKey2 = new System.Windows.Forms.PictureBox();
            this.pbKey1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucLoginInfo1 = new Presentation_Layer.UserControls.ucLoginInfo();
            this.ucPersonDetails1 = new Presentation_Layer.UserControls.ucPersonDetails();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(230, 93);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(220, 26);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(230, 13);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(220, 26);
            this.txtCurrentPassword.TabIndex = 0;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.Leave += new System.EventHandler(this.txtCurrentPassword_Leave);
            // 
            // lblConfirmPasswordTitle
            // 
            this.lblConfirmPasswordTitle.AutoSize = true;
            this.lblConfirmPasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordTitle.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmPasswordTitle.Location = new System.Drawing.Point(16, 96);
            this.lblConfirmPasswordTitle.Name = "lblConfirmPasswordTitle";
            this.lblConfirmPasswordTitle.Size = new System.Drawing.Size(158, 20);
            this.lblConfirmPasswordTitle.TabIndex = 141;
            this.lblConfirmPasswordTitle.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(230, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblPasswordTitle
            // 
            this.lblPasswordTitle.AutoSize = true;
            this.lblPasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordTitle.ForeColor = System.Drawing.Color.Black;
            this.lblPasswordTitle.Location = new System.Drawing.Point(78, 56);
            this.lblPasswordTitle.Name = "lblPasswordTitle";
            this.lblPasswordTitle.Size = new System.Drawing.Size(96, 20);
            this.lblPasswordTitle.TabIndex = 136;
            this.lblPasswordTitle.Text = "Password: ";
            // 
            // lblCurrentPasswordTitle
            // 
            this.lblCurrentPasswordTitle.AutoSize = true;
            this.lblCurrentPasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPasswordTitle.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentPasswordTitle.Location = new System.Drawing.Point(18, 16);
            this.lblCurrentPasswordTitle.Name = "lblCurrentPasswordTitle";
            this.lblCurrentPasswordTitle.Size = new System.Drawing.Size(156, 20);
            this.lblCurrentPasswordTitle.TabIndex = 135;
            this.lblCurrentPasswordTitle.Text = "Current Password:";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(565, 581);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Presentation_Layer.Properties.Resources.Save32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(705, 581);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbKey3
            // 
            this.pbKey3.Image = global::Presentation_Layer.Properties.Resources.Key;
            this.pbKey3.Location = new System.Drawing.Point(187, 93);
            this.pbKey3.Name = "pbKey3";
            this.pbKey3.Size = new System.Drawing.Size(25, 25);
            this.pbKey3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKey3.TabIndex = 144;
            this.pbKey3.TabStop = false;
            // 
            // pbKey2
            // 
            this.pbKey2.Image = global::Presentation_Layer.Properties.Resources.Key;
            this.pbKey2.Location = new System.Drawing.Point(187, 53);
            this.pbKey2.Name = "pbKey2";
            this.pbKey2.Size = new System.Drawing.Size(25, 25);
            this.pbKey2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKey2.TabIndex = 140;
            this.pbKey2.TabStop = false;
            // 
            // pbKey1
            // 
            this.pbKey1.Image = global::Presentation_Layer.Properties.Resources.Key;
            this.pbKey1.Location = new System.Drawing.Point(187, 13);
            this.pbKey1.Name = "pbKey1";
            this.pbKey1.Size = new System.Drawing.Size(25, 25);
            this.pbKey1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKey1.TabIndex = 139;
            this.pbKey1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbKey3);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.txtCurrentPassword);
            this.panel1.Controls.Add(this.lblConfirmPasswordTitle);
            this.panel1.Controls.Add(this.pbKey2);
            this.panel1.Controls.Add(this.pbKey1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblPasswordTitle);
            this.panel1.Controls.Add(this.lblCurrentPasswordTitle);
            this.panel1.Location = new System.Drawing.Point(12, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 132);
            this.panel1.TabIndex = 148;
            // 
            // ucLoginInfo1
            // 
            this.ucLoginInfo1.BackColor = System.Drawing.Color.White;
            this.ucLoginInfo1.Location = new System.Drawing.Point(12, 318);
            this.ucLoginInfo1.Name = "ucLoginInfo1";
            this.ucLoginInfo1.Size = new System.Drawing.Size(870, 94);
            this.ucLoginInfo1.TabIndex = 149;
            this.ucLoginInfo1.UserID = -1;
            // 
            // ucPersonDetails1
            // 
            this.ucPersonDetails1.BackColor = System.Drawing.Color.White;
            this.ucPersonDetails1.Location = new System.Drawing.Point(12, 12);
            this.ucPersonDetails1.Name = "ucPersonDetails1";
            this.ucPersonDetails1.PersonID = -1;
            this.ucPersonDetails1.Size = new System.Drawing.Size(870, 291);
            this.ucPersonDetails1.TabIndex = 147;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(891, 632);
            this.Controls.Add(this.ucLoginInfo1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucPersonDetails1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKey3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbKey3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblConfirmPasswordTitle;
        private System.Windows.Forms.PictureBox pbKey2;
        private System.Windows.Forms.PictureBox pbKey1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPasswordTitle;
        private System.Windows.Forms.Label lblCurrentPasswordTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private UserControls.ucPersonDetails ucPersonDetails1;
        private System.Windows.Forms.Panel panel1;
        private UserControls.ucLoginInfo ucLoginInfo1;
    }
}