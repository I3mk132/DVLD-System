namespace Presentation_Layer.UserControls
{
    partial class ucLoginInfo
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
            this.cbLoginInfo = new System.Windows.Forms.GroupBox();
            this.lblIsActiveValue = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserIDTitle = new System.Windows.Forms.Label();
            this.lblIsActiveTitle = new System.Windows.Forms.Label();
            this.lblUsernameTitle = new System.Windows.Forms.Label();
            this.pbIsActive = new System.Windows.Forms.PictureBox();
            this.pbUserNo = new System.Windows.Forms.PictureBox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.lblUsernameValue = new System.Windows.Forms.Label();
            this.cbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoginInfo
            // 
            this.cbLoginInfo.Controls.Add(this.lblUsernameValue);
            this.cbLoginInfo.Controls.Add(this.lblIsActiveValue);
            this.cbLoginInfo.Controls.Add(this.lblUserID);
            this.cbLoginInfo.Controls.Add(this.lblUserIDTitle);
            this.cbLoginInfo.Controls.Add(this.pbIsActive);
            this.cbLoginInfo.Controls.Add(this.pbUserNo);
            this.cbLoginInfo.Controls.Add(this.pbUsername);
            this.cbLoginInfo.Controls.Add(this.lblIsActiveTitle);
            this.cbLoginInfo.Controls.Add(this.lblUsernameTitle);
            this.cbLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoginInfo.Location = new System.Drawing.Point(13, 10);
            this.cbLoginInfo.Name = "cbLoginInfo";
            this.cbLoginInfo.Size = new System.Drawing.Size(738, 91);
            this.cbLoginInfo.TabIndex = 87;
            this.cbLoginInfo.TabStop = false;
            this.cbLoginInfo.Text = "Login info";
            // 
            // lblIsActiveValue
            // 
            this.lblIsActiveValue.AutoSize = true;
            this.lblIsActiveValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActiveValue.ForeColor = System.Drawing.Color.Black;
            this.lblIsActiveValue.Location = new System.Drawing.Point(618, 33);
            this.lblIsActiveValue.Name = "lblIsActiveValue";
            this.lblIsActiveValue.Size = new System.Drawing.Size(40, 24);
            this.lblIsActiveValue.TabIndex = 92;
            this.lblIsActiveValue.Text = "???";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.Location = new System.Drawing.Point(145, 33);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(40, 24);
            this.lblUserID.TabIndex = 86;
            this.lblUserID.Text = "???";
            // 
            // lblUserIDTitle
            // 
            this.lblUserIDTitle.AutoSize = true;
            this.lblUserIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblUserIDTitle.Location = new System.Drawing.Point(19, 33);
            this.lblUserIDTitle.Name = "lblUserIDTitle";
            this.lblUserIDTitle.Size = new System.Drawing.Size(76, 20);
            this.lblUserIDTitle.TabIndex = 85;
            this.lblUserIDTitle.Text = "User ID:";
            // 
            // lblIsActiveTitle
            // 
            this.lblIsActiveTitle.AutoSize = true;
            this.lblIsActiveTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActiveTitle.ForeColor = System.Drawing.Color.Black;
            this.lblIsActiveTitle.Location = new System.Drawing.Point(480, 32);
            this.lblIsActiveTitle.Name = "lblIsActiveTitle";
            this.lblIsActiveTitle.Size = new System.Drawing.Size(88, 20);
            this.lblIsActiveTitle.TabIndex = 53;
            this.lblIsActiveTitle.Text = "Is Active: ";
            // 
            // lblUsernameTitle
            // 
            this.lblUsernameTitle.AutoSize = true;
            this.lblUsernameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameTitle.ForeColor = System.Drawing.Color.Black;
            this.lblUsernameTitle.Location = new System.Drawing.Point(248, 33);
            this.lblUsernameTitle.Name = "lblUsernameTitle";
            this.lblUsernameTitle.Size = new System.Drawing.Size(65, 20);
            this.lblUsernameTitle.TabIndex = 47;
            this.lblUsernameTitle.Text = "Name: ";
            // 
            // pbIsActive
            // 
            this.pbIsActive.Image = global::Presentation_Layer.Properties.Resources.Key;
            this.pbIsActive.Location = new System.Drawing.Point(574, 31);
            this.pbIsActive.Name = "pbIsActive";
            this.pbIsActive.Size = new System.Drawing.Size(25, 25);
            this.pbIsActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIsActive.TabIndex = 80;
            this.pbIsActive.TabStop = false;
            // 
            // pbUserNo
            // 
            this.pbUserNo.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pbUserNo.Location = new System.Drawing.Point(101, 32);
            this.pbUserNo.Name = "pbUserNo";
            this.pbUserNo.Size = new System.Drawing.Size(25, 25);
            this.pbUserNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserNo.TabIndex = 74;
            this.pbUserNo.TabStop = false;
            // 
            // pbUsername
            // 
            this.pbUsername.Image = global::Presentation_Layer.Properties.Resources.Person;
            this.pbUsername.Location = new System.Drawing.Point(319, 31);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(25, 25);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsername.TabIndex = 73;
            this.pbUsername.TabStop = false;
            // 
            // lblUsernameValue
            // 
            this.lblUsernameValue.AutoSize = true;
            this.lblUsernameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameValue.ForeColor = System.Drawing.Color.Black;
            this.lblUsernameValue.Location = new System.Drawing.Point(361, 33);
            this.lblUsernameValue.Name = "lblUsernameValue";
            this.lblUsernameValue.Size = new System.Drawing.Size(40, 24);
            this.lblUsernameValue.TabIndex = 93;
            this.lblUsernameValue.Text = "???";
            // 
            // ucLoginInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbLoginInfo);
            this.Name = "ucLoginInfo";
            this.Size = new System.Drawing.Size(765, 113);
            this.cbLoginInfo.ResumeLayout(false);
            this.cbLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cbLoginInfo;
        private System.Windows.Forms.Label lblIsActiveValue;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserIDTitle;
        private System.Windows.Forms.PictureBox pbIsActive;
        private System.Windows.Forms.PictureBox pbUserNo;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.Label lblIsActiveTitle;
        private System.Windows.Forms.Label lblUsernameTitle;
        private System.Windows.Forms.Label lblUsernameValue;
    }
}
