namespace Presentation_Layer.ApplicationForms.LocalDrivingLicenseApplicationsForms
{
    partial class frmAddEditLDLApplication
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
            this.lblAddEditTitle = new System.Windows.Forms.Label();
            this.lblDLAppIDValue = new System.Windows.Forms.Label();
            this.lblApplicationFeesTitle = new System.Windows.Forms.Label();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlLoginInfo = new System.Windows.Forms.Panel();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblApplicationFeesValue = new System.Windows.Forms.Label();
            this.lblApplicationDateValue = new System.Windows.Forms.Label();
            this.lblCreatedByTitle = new System.Windows.Forms.Label();
            this.lblLicenseClassTitle = new System.Windows.Forms.Label();
            this.lblApplicationDateTitle = new System.Windows.Forms.Label();
            this.lblDLAppIDTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbCountry = new System.Windows.Forms.PictureBox();
            this.pbCreatedBy = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbPersonalInfo = new System.Windows.Forms.TabPage();
            this.ucPersonSearch1 = new Presentation_Layer.UserControls.ucPersonSearch();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tpLoginInfo.SuspendLayout();
            this.pnlLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbPersonalInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddEditTitle
            // 
            this.lblAddEditTitle.AutoSize = true;
            this.lblAddEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAddEditTitle.Location = new System.Drawing.Point(169, 9);
            this.lblAddEditTitle.Name = "lblAddEditTitle";
            this.lblAddEditTitle.Size = new System.Drawing.Size(633, 39);
            this.lblAddEditTitle.TabIndex = 7;
            this.lblAddEditTitle.Text = "Add Local Driving License Application";
            // 
            // lblDLAppIDValue
            // 
            this.lblDLAppIDValue.AutoSize = true;
            this.lblDLAppIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAppIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblDLAppIDValue.Location = new System.Drawing.Point(233, 45);
            this.lblDLAppIDValue.Name = "lblDLAppIDValue";
            this.lblDLAppIDValue.Size = new System.Drawing.Size(35, 20);
            this.lblDLAppIDValue.TabIndex = 132;
            this.lblDLAppIDValue.Text = "N/A";
            // 
            // lblApplicationFeesTitle
            // 
            this.lblApplicationFeesTitle.AutoSize = true;
            this.lblApplicationFeesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFeesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFeesTitle.Location = new System.Drawing.Point(21, 165);
            this.lblApplicationFeesTitle.Name = "lblApplicationFeesTitle";
            this.lblApplicationFeesTitle.Size = new System.Drawing.Size(153, 20);
            this.lblApplicationFeesTitle.TabIndex = 128;
            this.lblApplicationFeesTitle.Text = "Application Fees: ";
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.BackColor = System.Drawing.Color.White;
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
            this.pnlLoginInfo.BackColor = System.Drawing.Color.White;
            this.pnlLoginInfo.Controls.Add(this.cbLicenseClasses);
            this.pnlLoginInfo.Controls.Add(this.pictureBox3);
            this.pnlLoginInfo.Controls.Add(this.lblCreatedByValue);
            this.pnlLoginInfo.Controls.Add(this.lblApplicationFeesValue);
            this.pnlLoginInfo.Controls.Add(this.lblApplicationDateValue);
            this.pnlLoginInfo.Controls.Add(this.lblCreatedByTitle);
            this.pnlLoginInfo.Controls.Add(this.lblDLAppIDValue);
            this.pnlLoginInfo.Controls.Add(this.lblApplicationFeesTitle);
            this.pnlLoginInfo.Controls.Add(this.lblLicenseClassTitle);
            this.pnlLoginInfo.Controls.Add(this.lblApplicationDateTitle);
            this.pnlLoginInfo.Controls.Add(this.lblDLAppIDTitle);
            this.pnlLoginInfo.Controls.Add(this.pictureBox2);
            this.pnlLoginInfo.Controls.Add(this.pbCountry);
            this.pnlLoginInfo.Controls.Add(this.pbCreatedBy);
            this.pnlLoginInfo.Controls.Add(this.pictureBox1);
            this.pnlLoginInfo.Location = new System.Drawing.Point(22, 11);
            this.pnlLoginInfo.Name = "pnlLoginInfo";
            this.pnlLoginInfo.Size = new System.Drawing.Size(892, 250);
            this.pnlLoginInfo.TabIndex = 134;
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(237, 125);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(299, 28);
            this.cbLicenseClasses.TabIndex = 138;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentation_Layer.Properties.Resources.Calendar;
            this.pictureBox3.Location = new System.Drawing.Point(185, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 137;
            this.pictureBox3.TabStop = false;
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByValue.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByValue.Location = new System.Drawing.Point(233, 198);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(35, 20);
            this.lblCreatedByValue.TabIndex = 136;
            this.lblCreatedByValue.Text = "N/A";
            // 
            // lblApplicationFeesValue
            // 
            this.lblApplicationFeesValue.AutoSize = true;
            this.lblApplicationFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFeesValue.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFeesValue.Location = new System.Drawing.Point(233, 165);
            this.lblApplicationFeesValue.Name = "lblApplicationFeesValue";
            this.lblApplicationFeesValue.Size = new System.Drawing.Size(35, 20);
            this.lblApplicationFeesValue.TabIndex = 135;
            this.lblApplicationFeesValue.Text = "N/A";
            // 
            // lblApplicationDateValue
            // 
            this.lblApplicationDateValue.AutoSize = true;
            this.lblApplicationDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDateValue.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDateValue.Location = new System.Drawing.Point(233, 85);
            this.lblApplicationDateValue.Name = "lblApplicationDateValue";
            this.lblApplicationDateValue.Size = new System.Drawing.Size(35, 20);
            this.lblApplicationDateValue.TabIndex = 134;
            this.lblApplicationDateValue.Text = "N/A";
            // 
            // lblCreatedByTitle
            // 
            this.lblCreatedByTitle.AutoSize = true;
            this.lblCreatedByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByTitle.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByTitle.Location = new System.Drawing.Point(66, 198);
            this.lblCreatedByTitle.Name = "lblCreatedByTitle";
            this.lblCreatedByTitle.Size = new System.Drawing.Size(108, 20);
            this.lblCreatedByTitle.TabIndex = 133;
            this.lblCreatedByTitle.Text = "Created By: ";
            // 
            // lblLicenseClassTitle
            // 
            this.lblLicenseClassTitle.AutoSize = true;
            this.lblLicenseClassTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseClassTitle.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseClassTitle.Location = new System.Drawing.Point(44, 125);
            this.lblLicenseClassTitle.Name = "lblLicenseClassTitle";
            this.lblLicenseClassTitle.Size = new System.Drawing.Size(130, 20);
            this.lblLicenseClassTitle.TabIndex = 121;
            this.lblLicenseClassTitle.Text = "License Class: ";
            // 
            // lblApplicationDateTitle
            // 
            this.lblApplicationDateTitle.AutoSize = true;
            this.lblApplicationDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDateTitle.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDateTitle.Location = new System.Drawing.Point(22, 85);
            this.lblApplicationDateTitle.Name = "lblApplicationDateTitle";
            this.lblApplicationDateTitle.Size = new System.Drawing.Size(152, 20);
            this.lblApplicationDateTitle.TabIndex = 120;
            this.lblApplicationDateTitle.Text = "Application Date: ";
            // 
            // lblDLAppIDTitle
            // 
            this.lblDLAppIDTitle.AutoSize = true;
            this.lblDLAppIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAppIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblDLAppIDTitle.Location = new System.Drawing.Point(14, 45);
            this.lblDLAppIDTitle.Name = "lblDLAppIDTitle";
            this.lblDLAppIDTitle.Size = new System.Drawing.Size(160, 20);
            this.lblDLAppIDTitle.TabIndex = 119;
            this.lblDLAppIDTitle.Text = "D.L.Application ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentation_Layer.Properties.Resources.Fees32;
            this.pictureBox2.Location = new System.Drawing.Point(185, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 131;
            this.pictureBox2.TabStop = false;
            // 
            // pbCountry
            // 
            this.pbCountry.Image = global::Presentation_Layer.Properties.Resources.License_pink;
            this.pbCountry.Location = new System.Drawing.Point(180, 122);
            this.pbCountry.Name = "pbCountry";
            this.pbCountry.Size = new System.Drawing.Size(37, 34);
            this.pbCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCountry.TabIndex = 127;
            this.pbCountry.TabStop = false;
            // 
            // pbCreatedBy
            // 
            this.pbCreatedBy.Image = global::Presentation_Layer.Properties.Resources.Person;
            this.pbCreatedBy.Location = new System.Drawing.Point(185, 198);
            this.pbCreatedBy.Name = "pbCreatedBy";
            this.pbCreatedBy.Size = new System.Drawing.Size(25, 25);
            this.pbCreatedBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCreatedBy.TabIndex = 126;
            this.pbCreatedBy.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pictureBox1.Location = new System.Drawing.Point(185, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            // 
            // tbPersonalInfo
            // 
            this.tbPersonalInfo.BackColor = System.Drawing.Color.White;
            this.tbPersonalInfo.Controls.Add(this.ucPersonSearch1);
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
            this.ucPersonSearch1.BackColor = System.Drawing.Color.White;
            this.ucPersonSearch1.Location = new System.Drawing.Point(35, 31);
            this.ucPersonSearch1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPersonSearch1.Name = "ucPersonSearch1";
            this.ucPersonSearch1.Size = new System.Drawing.Size(870, 368);
            this.ucPersonSearch1.TabIndex = 0;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPersonalInfo);
            this.tabControl1.Controls.Add(this.tpLoginInfo);
            this.tabControl1.Location = new System.Drawing.Point(10, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 507);
            this.tabControl1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(678, 561);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 6;
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
            this.btnSave.Location = new System.Drawing.Point(818, 561);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditLDLApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(963, 614);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddEditTitle);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddEditLDLApplication";
            this.Text = "frmAddEditLDLApplication";
            this.Load += new System.EventHandler(this.frmAddEditLDLApplication_Load);
            this.tpLoginInfo.ResumeLayout(false);
            this.pnlLoginInfo.ResumeLayout(false);
            this.pnlLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbPersonalInfo.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAddEditTitle;
        private System.Windows.Forms.Label lblDLAppIDValue;
        private System.Windows.Forms.Label lblApplicationFeesTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.Panel pnlLoginInfo;
        private System.Windows.Forms.Label lblLicenseClassTitle;
        private System.Windows.Forms.Label lblApplicationDateTitle;
        private System.Windows.Forms.Label lblDLAppIDTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbCountry;
        private System.Windows.Forms.PictureBox pbCreatedBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.ucPersonSearch ucPersonSearch1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tbPersonalInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label lblApplicationFeesValue;
        private System.Windows.Forms.Label lblApplicationDateValue;
        private System.Windows.Forms.Label lblCreatedByTitle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
    }
}