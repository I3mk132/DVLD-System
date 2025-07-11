namespace Presentation_Layer.UserForms
{
    partial class frmAddEditUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPersonalInfo = new System.Windows.Forms.TabPage();
            this.ucPersonSearch1 = new Presentation_Layer.UserControls.ucPersonSearch();
            this.ucPersonDetails1 = new Presentation_Layer.UserControls.ucPersonDetails();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlLoginInfo = new System.Windows.Forms.Panel();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblConfirmPasswordTitle = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordTitle = new System.Windows.Forms.Label();
            this.lblUsernameTitle = new System.Windows.Forms.Label();
            this.lblUserIDTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbCountry = new System.Windows.Forms.PictureBox();
            this.pbPhone = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddEditTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbPersonalInfo.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            this.pnlLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPersonalInfo);
            this.tabControl1.Controls.Add(this.tpLoginInfo);
            this.tabControl1.Location = new System.Drawing.Point(27, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPersonalInfo
            // 
            this.tbPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.tbPersonalInfo.Controls.Add(this.ucPersonSearch1);
            this.tbPersonalInfo.Controls.Add(this.ucPersonDetails1);
            this.tbPersonalInfo.Controls.Add(this.btnNext);
            this.tbPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tbPersonalInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tbPersonalInfo.Name = "tbPersonalInfo";
            this.tbPersonalInfo.Size = new System.Drawing.Size(934, 481);
            this.tbPersonalInfo.TabIndex = 0;
            this.tbPersonalInfo.Text = "Personal info";
            // 
            // ucPersonSearch1
            // 
            this.ucPersonSearch1.BackColor = System.Drawing.SystemColors.Control;
            this.ucPersonSearch1.Location = new System.Drawing.Point(35, 24);
            this.ucPersonSearch1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPersonSearch1.Name = "ucPersonSearch1";
            this.ucPersonSearch1.Size = new System.Drawing.Size(870, 86);
            this.ucPersonSearch1.TabIndex = 0;
            // 
            // ucPersonDetails1
            // 
            this.ucPersonDetails1.BackColor = System.Drawing.SystemColors.Control;
            this.ucPersonDetails1.Location = new System.Drawing.Point(35, 130);
            this.ucPersonDetails1.Name = "ucPersonDetails1";
            this.ucPersonDetails1.PersonID = -1;
            this.ucPersonDetails1.Size = new System.Drawing.Size(870, 291);
            this.ucPersonDetails1.TabIndex = 9;
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::Presentation_Layer.Properties.Resources.Next32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(771, 427);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(134, 40);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.tpLoginInfo.Controls.Add(this.btnBack);
            this.tpLoginInfo.Controls.Add(this.pnlLoginInfo);
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(934, 481);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Login Info";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::Presentation_Layer.Properties.Resources.Back32;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(771, 427);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 40);
            this.btnBack.TabIndex = 135;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlLoginInfo
            // 
            this.pnlLoginInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLoginInfo.Controls.Add(this.chkIsActive);
            this.pnlLoginInfo.Controls.Add(this.lblUserIDValue);
            this.pnlLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.pnlLoginInfo.Controls.Add(this.txtUsername);
            this.pnlLoginInfo.Controls.Add(this.lblConfirmPasswordTitle);
            this.pnlLoginInfo.Controls.Add(this.txtPassword);
            this.pnlLoginInfo.Controls.Add(this.lblPasswordTitle);
            this.pnlLoginInfo.Controls.Add(this.lblUsernameTitle);
            this.pnlLoginInfo.Controls.Add(this.lblUserIDTitle);
            this.pnlLoginInfo.Controls.Add(this.pictureBox2);
            this.pnlLoginInfo.Controls.Add(this.pbCountry);
            this.pnlLoginInfo.Controls.Add(this.pbPhone);
            this.pnlLoginInfo.Controls.Add(this.pictureBox1);
            this.pnlLoginInfo.Location = new System.Drawing.Point(22, 11);
            this.pnlLoginInfo.Name = "pnlLoginInfo";
            this.pnlLoginInfo.Size = new System.Drawing.Size(892, 250);
            this.pnlLoginInfo.TabIndex = 134;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Location = new System.Drawing.Point(227, 197);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(88, 24);
            this.chkIsActive.TabIndex = 3;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblUserIDValue
            // 
            this.lblUserIDValue.AutoSize = true;
            this.lblUserIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblUserIDValue.Location = new System.Drawing.Point(223, 45);
            this.lblUserIDValue.Name = "lblUserIDValue";
            this.lblUserIDValue.Size = new System.Drawing.Size(35, 20);
            this.lblUserIDValue.TabIndex = 132;
            this.lblUserIDValue.Text = "N/A";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(218, 165);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(155, 26);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(218, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(155, 26);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblConfirmPasswordTitle
            // 
            this.lblConfirmPasswordTitle.AutoSize = true;
            this.lblConfirmPasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordTitle.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmPasswordTitle.Location = new System.Drawing.Point(11, 165);
            this.lblConfirmPasswordTitle.Name = "lblConfirmPasswordTitle";
            this.lblConfirmPasswordTitle.Size = new System.Drawing.Size(158, 20);
            this.lblConfirmPasswordTitle.TabIndex = 128;
            this.lblConfirmPasswordTitle.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(218, 125);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblPasswordTitle
            // 
            this.lblPasswordTitle.AutoSize = true;
            this.lblPasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordTitle.ForeColor = System.Drawing.Color.Black;
            this.lblPasswordTitle.Location = new System.Drawing.Point(73, 125);
            this.lblPasswordTitle.Name = "lblPasswordTitle";
            this.lblPasswordTitle.Size = new System.Drawing.Size(96, 20);
            this.lblPasswordTitle.TabIndex = 121;
            this.lblPasswordTitle.Text = "Password: ";
            // 
            // lblUsernameTitle
            // 
            this.lblUsernameTitle.AutoSize = true;
            this.lblUsernameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameTitle.ForeColor = System.Drawing.Color.Black;
            this.lblUsernameTitle.Location = new System.Drawing.Point(68, 85);
            this.lblUsernameTitle.Name = "lblUsernameTitle";
            this.lblUsernameTitle.Size = new System.Drawing.Size(101, 20);
            this.lblUsernameTitle.TabIndex = 120;
            this.lblUsernameTitle.Text = "Username: ";
            // 
            // lblUserIDTitle
            // 
            this.lblUserIDTitle.AutoSize = true;
            this.lblUserIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblUserIDTitle.Location = new System.Drawing.Point(88, 45);
            this.lblUserIDTitle.Name = "lblUserIDTitle";
            this.lblUserIDTitle.Size = new System.Drawing.Size(81, 20);
            this.lblUserIDTitle.TabIndex = 119;
            this.lblUserIDTitle.Text = "User ID: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentation_Layer.Properties.Resources.Key;
            this.pictureBox2.Location = new System.Drawing.Point(175, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 131;
            this.pictureBox2.TabStop = false;
            // 
            // pbCountry
            // 
            this.pbCountry.Image = global::Presentation_Layer.Properties.Resources.Key;
            this.pbCountry.Location = new System.Drawing.Point(175, 125);
            this.pbCountry.Name = "pbCountry";
            this.pbCountry.Size = new System.Drawing.Size(25, 25);
            this.pbCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCountry.TabIndex = 127;
            this.pbCountry.TabStop = false;
            // 
            // pbPhone
            // 
            this.pbPhone.Image = global::Presentation_Layer.Properties.Resources.Person;
            this.pbPhone.Location = new System.Drawing.Point(175, 85);
            this.pbPhone.Name = "pbPhone";
            this.pbPhone.Size = new System.Drawing.Size(25, 25);
            this.pbPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhone.TabIndex = 126;
            this.pbPhone.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pictureBox1.Location = new System.Drawing.Point(175, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddEditTitle
            // 
            this.lblAddEditTitle.AutoSize = true;
            this.lblAddEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAddEditTitle.Location = new System.Drawing.Point(396, 32);
            this.lblAddEditTitle.Name = "lblAddEditTitle";
            this.lblAddEditTitle.Size = new System.Drawing.Size(169, 39);
            this.lblAddEditTitle.TabIndex = 3;
            this.lblAddEditTitle.Text = "Add User";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(695, 601);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 2;
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
            this.btnSave.Location = new System.Drawing.Point(835, 601);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(981, 653);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddEditTitle);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbPersonalInfo.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.pnlLoginInfo.ResumeLayout(false);
            this.pnlLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPersonalInfo;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.Label lblAddEditTitle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pbCountry;
        private System.Windows.Forms.PictureBox pbPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPasswordTitle;
        private System.Windows.Forms.Label lblUsernameTitle;
        private System.Windows.Forms.Label lblUserIDTitle;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblConfirmPasswordTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserIDValue;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private UserControls.ucPersonDetails ucPersonDetails1;
        private UserControls.ucPersonSearch ucPersonSearch1;
        private System.Windows.Forms.Panel pnlLoginInfo;
        private System.Windows.Forms.Button btnBack;
    }
}