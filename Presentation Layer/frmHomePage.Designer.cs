﻿namespace Presentation_Layer
{
    partial class frmHomePage
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
            this.msiDriverLicensesServices = new System.Windows.Forms.ToolStripMenuItem();
            this.msiManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDetainLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.msiManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.msiManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.msiPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.msiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.msiInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.msiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.msiSignout = new System.Windows.Forms.ToolStripMenuItem();
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
            this.msiApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiDriverLicensesServices,
            this.msiManageApplications,
            this.msiDetainLicenses,
            this.msiManageApplicationTypes,
            this.msiManageTestTypes});
            this.msiApplications.Image = global::Presentation_Layer.Properties.Resources.Applications;
            this.msiApplications.Name = "msiApplications";
            this.msiApplications.Size = new System.Drawing.Size(182, 52);
            this.msiApplications.Text = "Applications";
            // 
            // msiDriverLicensesServices
            // 
            this.msiDriverLicensesServices.Image = global::Presentation_Layer.Properties.Resources.License1;
            this.msiDriverLicensesServices.Name = "msiDriverLicensesServices";
            this.msiDriverLicensesServices.Size = new System.Drawing.Size(350, 54);
            this.msiDriverLicensesServices.Text = "Driver Licenses Services";
            // 
            // msiManageApplications
            // 
            this.msiManageApplications.Image = global::Presentation_Layer.Properties.Resources.DocumentSettings;
            this.msiManageApplications.Name = "msiManageApplications";
            this.msiManageApplications.Size = new System.Drawing.Size(350, 54);
            this.msiManageApplications.Text = "Manage Applications";
            // 
            // msiDetainLicenses
            // 
            this.msiDetainLicenses.Image = global::Presentation_Layer.Properties.Resources.LockedCard;
            this.msiDetainLicenses.Name = "msiDetainLicenses";
            this.msiDetainLicenses.Size = new System.Drawing.Size(350, 54);
            this.msiDetainLicenses.Text = "Detain Licenses";
            // 
            // msiManageApplicationTypes
            // 
            this.msiManageApplicationTypes.Image = global::Presentation_Layer.Properties.Resources.DocumentSettings1;
            this.msiManageApplicationTypes.Name = "msiManageApplicationTypes";
            this.msiManageApplicationTypes.Size = new System.Drawing.Size(350, 54);
            this.msiManageApplicationTypes.Text = "Manage Application Types";
            this.msiManageApplicationTypes.Click += new System.EventHandler(this.msiManageApplicationTypes_Click);
            // 
            // msiManageTestTypes
            // 
            this.msiManageTestTypes.Image = global::Presentation_Layer.Properties.Resources.DocumentSettings2;
            this.msiManageTestTypes.Name = "msiManageTestTypes";
            this.msiManageTestTypes.Size = new System.Drawing.Size(350, 54);
            this.msiManageTestTypes.Text = "Manage Test Types";
            this.msiManageTestTypes.Click += new System.EventHandler(this.msiManageTestTypes_Click);
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
            this.msiUsers.Click += new System.EventHandler(this.msiUsers_Click);
            // 
            // msiAccountSettings
            // 
            this.msiAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiInformation,
            this.msiChangePassword,
            this.msiSeperator,
            this.msiSignout});
            this.msiAccountSettings.Image = global::Presentation_Layer.Properties.Resources.Account_Settings;
            this.msiAccountSettings.Name = "msiAccountSettings";
            this.msiAccountSettings.Size = new System.Drawing.Size(223, 52);
            this.msiAccountSettings.Text = "Account Settings";
            // 
            // msiInformation
            // 
            this.msiInformation.Image = global::Presentation_Layer.Properties.Resources.User;
            this.msiInformation.Name = "msiInformation";
            this.msiInformation.Size = new System.Drawing.Size(273, 54);
            this.msiInformation.Text = "Current User Info";
            this.msiInformation.Click += new System.EventHandler(this.msiInformation_Click);
            // 
            // msiChangePassword
            // 
            this.msiChangePassword.Image = global::Presentation_Layer.Properties.Resources.Password;
            this.msiChangePassword.Name = "msiChangePassword";
            this.msiChangePassword.Size = new System.Drawing.Size(273, 54);
            this.msiChangePassword.Text = "Change password";
            this.msiChangePassword.Click += new System.EventHandler(this.msiChangePassword_Click);
            // 
            // msiSeperator
            // 
            this.msiSeperator.Name = "msiSeperator";
            this.msiSeperator.Size = new System.Drawing.Size(270, 6);
            // 
            // msiSignout
            // 
            this.msiSignout.Image = global::Presentation_Layer.Properties.Resources.Logout;
            this.msiSignout.Name = "msiSignout";
            this.msiSignout.Size = new System.Drawing.Size(273, 54);
            this.msiSignout.Text = "Sign out";
            this.msiSignout.Click += new System.EventHandler(this.msiSignout_Click);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1101, 562);
            this.Controls.Add(this.msMenues);
            this.MainMenuStrip = this.msMenues;
            this.Name = "frmHomePage";
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
        private System.Windows.Forms.ToolStripMenuItem msiInformation;
        private System.Windows.Forms.ToolStripMenuItem msiChangePassword;
        private System.Windows.Forms.ToolStripMenuItem msiSignout;
        private System.Windows.Forms.ToolStripSeparator msiSeperator;
        private System.Windows.Forms.ToolStripMenuItem msiDriverLicensesServices;
        private System.Windows.Forms.ToolStripMenuItem msiManageApplications;
        private System.Windows.Forms.ToolStripMenuItem msiDetainLicenses;
        private System.Windows.Forms.ToolStripMenuItem msiManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem msiManageTestTypes;
    }
}

