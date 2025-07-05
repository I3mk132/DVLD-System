namespace Presentation_Layer
{
    partial class HomePage
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
            this.msMenues = new System.Windows.Forms.MenuStrip();
            this.msiApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.msiPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.msiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenues.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenues
            // 
            this.msMenues.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenues.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.msMenues.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiApplications,
            this.msiPeople,
            this.msiDrivers,
            this.msiUsers,
            this.msiAccountSettings});
            this.msMenues.Location = new System.Drawing.Point(0, 0);
            this.msMenues.Name = "msMenues";
            this.msMenues.Size = new System.Drawing.Size(1101, 56);
            this.msMenues.TabIndex = 0;
            this.msMenues.Text = "Menues";
            // 
            // msiApplications
            // 
            this.msiApplications.Image = global::Presentation_Layer.Properties.Resources.Applications;
            this.msiApplications.Name = "msiApplications";
            this.msiApplications.Size = new System.Drawing.Size(182, 52);
            this.msiApplications.Text = "Applications";
            // 
            // msiPeople
            // 
            this.msiPeople.Image = global::Presentation_Layer.Properties.Resources.People;
            this.msiPeople.Name = "msiPeople";
            this.msiPeople.Size = new System.Drawing.Size(132, 52);
            this.msiPeople.Text = "People";
            this.msiPeople.Click += new System.EventHandler(this.msiPeople_Click);
            // 
            // msiDrivers
            // 
            this.msiDrivers.Image = global::Presentation_Layer.Properties.Resources.Drivers;
            this.msiDrivers.Name = "msiDrivers";
            this.msiDrivers.Size = new System.Drawing.Size(135, 52);
            this.msiDrivers.Text = "Drivers";
            // 
            // msiUsers
            // 
            this.msiUsers.Image = global::Presentation_Layer.Properties.Resources.Users;
            this.msiUsers.Name = "msiUsers";
            this.msiUsers.Size = new System.Drawing.Size(120, 52);
            this.msiUsers.Text = "Users";
            // 
            // msiAccountSettings
            // 
            this.msiAccountSettings.Image = global::Presentation_Layer.Properties.Resources.Account_Settings;
            this.msiAccountSettings.Name = "msiAccountSettings";
            this.msiAccountSettings.Size = new System.Drawing.Size(223, 52);
            this.msiAccountSettings.Text = "Account Settings";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1101, 562);
            this.Controls.Add(this.msMenues);
            this.MainMenuStrip = this.msMenues;
            this.Name = "HomePage";
            this.Text = "Home page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenues.ResumeLayout(false);
            this.msMenues.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenues;
        private System.Windows.Forms.ToolStripMenuItem msiApplications;
        private System.Windows.Forms.ToolStripMenuItem msiPeople;
        private System.Windows.Forms.ToolStripMenuItem msiDrivers;
        private System.Windows.Forms.ToolStripMenuItem msiUsers;
        private System.Windows.Forms.ToolStripMenuItem msiAccountSettings;
    }
}

