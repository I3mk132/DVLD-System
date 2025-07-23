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
            this.lblUsernameValue = new System.Windows.Forms.Label();
            this.lblIsActiveValue = new System.Windows.Forms.Label();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.lblUserIDTitle = new System.Windows.Forms.Label();
            this.pbIsActive = new System.Windows.Forms.PictureBox();
            this.pbUserNo = new System.Windows.Forms.PictureBox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.lblIsActiveTitle = new System.Windows.Forms.Label();
            this.lblUsernameTitle = new System.Windows.Forms.Label();
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
            this.cbLoginInfo.Controls.Add(this.lblUserIDValue);
            this.cbLoginInfo.Controls.Add(this.lblUserIDTitle);
            this.cbLoginInfo.Controls.Add(this.pbIsActive);
            this.cbLoginInfo.Controls.Add(this.pbUserNo);
            this.cbLoginInfo.Controls.Add(this.pbUsername);
            this.cbLoginInfo.Controls.Add(this.lblIsActiveTitle);
            this.cbLoginInfo.Controls.Add(this.lblUsernameTitle);
            this.cbLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoginInfo.Location = new System.Drawing.Point(13, 10);
            this.cbLoginInfo.Name = "cbLoginInfo";
            this.cbLoginInfo.Size = new System.Drawing.Size(843, 70);
            this.cbLoginInfo.TabIndex = 87;
            this.cbLoginInfo.TabStop = false;
            this.cbLoginInfo.Text = "Login info";
            // 
            // lblUsernameValue
            // 
            this.lblUsernameValue.AutoSize = true;
            this.lblUsernameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameValue.ForeColor = System.Drawing.Color.Black;
            this.lblUsernameValue.Location = new System.Drawing.Point(379, 22);
            this.lblUsernameValue.Name = "lblUsernameValue";
            this.lblUsernameValue.Size = new System.Drawing.Size(40, 24);
            this.lblUsernameValue.TabIndex = 93;
            this.lblUsernameValue.Text = "???";
            // 
            // lblIsActiveValue
            // 
            this.lblIsActiveValue.AutoSize = true;
            this.lblIsActiveValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActiveValue.ForeColor = System.Drawing.Color.Black;
            this.lblIsActiveValue.Location = new System.Drawing.Point(599, 22);
            this.lblIsActiveValue.Name = "lblIsActiveValue";
            this.lblIsActiveValue.Size = new System.Drawing.Size(40, 24);
            this.lblIsActiveValue.TabIndex = 92;
            this.lblIsActiveValue.Text = "???";
            // 
            // lblUserIDValue
            // 
            this.lblUserIDValue.AutoSize = true;
            this.lblUserIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblUserIDValue.Location = new System.Drawing.Point(127, 22);
            this.lblUserIDValue.Name = "lblUserIDValue";
            this.lblUserIDValue.Size = new System.Drawing.Size(40, 24);
            this.lblUserIDValue.TabIndex = 86;
            this.lblUserIDValue.Text = "???";
            // 
            // lblUserIDTitle
            // 
            this.lblUserIDTitle.AutoSize = true;
            this.lblUserIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblUserIDTitle.Location = new System.Drawing.Point(19, 26);
            this.lblUserIDTitle.Name = "lblUserIDTitle";
            this.lblUserIDTitle.Size = new System.Drawing.Size(76, 20);
            this.lblUserIDTitle.TabIndex = 85;
            this.lblUserIDTitle.Text = "User ID:";
            // 
            // pbIsActive
            // 
            this.pbIsActive.Image = global::Presentation_Layer.Properties.Resources.Key;
            this.pbIsActive.Location = new System.Drawing.Point(571, 24);
            this.pbIsActive.Name = "pbIsActive";
            this.pbIsActive.Size = new System.Drawing.Size(25, 25);
            this.pbIsActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIsActive.TabIndex = 80;
            this.pbIsActive.TabStop = false;
            // 
            // pbUserNo
            // 
            this.pbUserNo.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pbUserNo.Location = new System.Drawing.Point(98, 23);
            this.pbUserNo.Name = "pbUserNo";
            this.pbUserNo.Size = new System.Drawing.Size(25, 25);
            this.pbUserNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserNo.TabIndex = 74;
            this.pbUserNo.TabStop = false;
            // 
            // pbUsername
            // 
            this.pbUsername.Image = global::Presentation_Layer.Properties.Resources.Person;
            this.pbUsername.Location = new System.Drawing.Point(351, 24);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(25, 25);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsername.TabIndex = 73;
            this.pbUsername.TabStop = false;
            // 
            // lblIsActiveTitle
            // 
            this.lblIsActiveTitle.AutoSize = true;
            this.lblIsActiveTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActiveTitle.ForeColor = System.Drawing.Color.Black;
            this.lblIsActiveTitle.Location = new System.Drawing.Point(480, 26);
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
            this.lblUsernameTitle.Location = new System.Drawing.Point(248, 26);
            this.lblUsernameTitle.Name = "lblUsernameTitle";
            this.lblUsernameTitle.Size = new System.Drawing.Size(101, 20);
            this.lblUsernameTitle.TabIndex = 47;
            this.lblUsernameTitle.Text = "Username: ";
            // 
            // ucLoginInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbLoginInfo);
            this.Name = "ucLoginInfo";
            this.Size = new System.Drawing.Size(870, 97);
            this.Load += new System.EventHandler(this.ucLoginInfo_Load);
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
        private System.Windows.Forms.Label lblUserIDValue;
        private System.Windows.Forms.Label lblUserIDTitle;
        private System.Windows.Forms.PictureBox pbIsActive;
        private System.Windows.Forms.PictureBox pbUserNo;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.Label lblIsActiveTitle;
        private System.Windows.Forms.Label lblUsernameTitle;
        private System.Windows.Forms.Label lblUsernameValue;
    }
}
