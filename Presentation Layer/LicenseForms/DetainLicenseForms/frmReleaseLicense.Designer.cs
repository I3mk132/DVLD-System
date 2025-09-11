namespace Presentation_Layer.LicenseForms.DetainLicenseForms
{
    partial class frmReleaseLicense
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
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ucLicenseCard1 = new Presentation_Layer.UserControls.LicenseUserControls.ucLicenseCard();
            this.lblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReleaseLicense = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalFeesTitle = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblFineFeesTitle = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.lblCreatedByTitle = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblLicenseIDTitle = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblDetainDateTitle = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblAppFeesTitle = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblApplicationFee = new System.Windows.Forms.Label();
            this.lblApplicationIDTitle = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblDetainIDTitle = new System.Windows.Forms.Label();
            this.pbUserNo = new System.Windows.Forms.PictureBox();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.gbFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(176, 31);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(153, 26);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.White;
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.lblFilter);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Location = new System.Drawing.Point(51, 70);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(714, 80);
            this.gbFilter.TabIndex = 164;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.DimGray;
            this.lblFilter.Location = new System.Drawing.Point(24, 30);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(132, 26);
            this.lblFilter.TabIndex = 14;
            this.lblFilter.Text = "License ID:";
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.AutoSize = true;
            this.lblShowLicenseInfo.Enabled = false;
            this.lblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(239, 722);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(169, 24);
            this.lblShowLicenseInfo.TabIndex = 170;
            this.lblShowLicenseInfo.TabStop = true;
            this.lblShowLicenseInfo.Text = "Show License Info.";
            this.lblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseInfo_LinkClicked);
            // 
            // ucLicenseCard1
            // 
            this.ucLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ucLicenseCard1.Location = new System.Drawing.Point(10, 156);
            this.ucLicenseCard1.Name = "ucLicenseCard1";
            this.ucLicenseCard1.Padding = new System.Windows.Forms.Padding(5);
            this.ucLicenseCard1.Size = new System.Drawing.Size(780, 333);
            this.ucLicenseCard1.TabIndex = 165;
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.AutoSize = true;
            this.lblShowLicenseHistory.Enabled = false;
            this.lblShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(23, 722);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(196, 24);
            this.lblShowLicenseHistory.TabIndex = 167;
            this.lblShowLicenseHistory.TabStop = true;
            this.lblShowLicenseHistory.Text = "Show License History.";
            this.lblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseHistory_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalFeesTitle);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.lblTotalFees);
            this.groupBox1.Controls.Add(this.lblFineFeesTitle);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.lblFineFees);
            this.groupBox1.Controls.Add(this.lblCreatedByTitle);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.lblLicenseIDTitle);
            this.groupBox1.Controls.Add(this.lblLicenseID);
            this.groupBox1.Controls.Add(this.lblDetainDateTitle);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.lblDetainDate);
            this.groupBox1.Controls.Add(this.lblAppFeesTitle);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.lblApplicationFee);
            this.groupBox1.Controls.Add(this.lblApplicationIDTitle);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblApplicationID);
            this.groupBox1.Controls.Add(this.lblDetainIDTitle);
            this.groupBox1.Controls.Add(this.pbUserNo);
            this.groupBox1.Controls.Add(this.lblDetainID);
            this.groupBox1.Location = new System.Drawing.Point(15, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 195);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Release License Application Info";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(10, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 214);
            this.panel1.TabIndex = 166;
            // 
            // lblReleaseLicense
            // 
            this.lblReleaseLicense.AutoSize = true;
            this.lblReleaseLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseLicense.ForeColor = System.Drawing.Color.Firebrick;
            this.lblReleaseLicense.Location = new System.Drawing.Point(290, 29);
            this.lblReleaseLicense.Name = "lblReleaseLicense";
            this.lblReleaseLicense.Size = new System.Drawing.Size(230, 31);
            this.lblReleaseLicense.TabIndex = 171;
            this.lblReleaseLicense.Text = "Release License";
            // 
            // btnFind
            // 
            this.btnFind.Image = global::Presentation_Layer.Properties.Resources.Search;
            this.btnFind.Location = new System.Drawing.Point(350, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(54, 41);
            this.btnFind.TabIndex = 15;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblSave
            // 
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Enabled = false;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.Image = global::Presentation_Layer.Properties.Resources.Save32;
            this.lblSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSave.Location = new System.Drawing.Point(594, 715);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(196, 40);
            this.lblSave.TabIndex = 169;
            this.lblSave.Text = "Release License";
            this.lblSave.UseVisualStyleBackColor = true;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(454, 715);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 168;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalFeesTitle
            // 
            this.lblTotalFeesTitle.AutoSize = true;
            this.lblTotalFeesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFeesTitle.Location = new System.Drawing.Point(357, 149);
            this.lblTotalFeesTitle.Name = "lblTotalFeesTitle";
            this.lblTotalFeesTitle.Size = new System.Drawing.Size(99, 20);
            this.lblTotalFeesTitle.TabIndex = 162;
            this.lblTotalFeesTitle.Text = "Total Fees:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Presentation_Layer.Properties.Resources.Fees32;
            this.pictureBox9.Location = new System.Drawing.Point(547, 145);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(25, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 161;
            this.pictureBox9.TabStop = false;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFees.Location = new System.Drawing.Point(588, 146);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(40, 24);
            this.lblTotalFees.TabIndex = 163;
            this.lblTotalFees.Text = "???";
            // 
            // lblFineFeesTitle
            // 
            this.lblFineFeesTitle.AutoSize = true;
            this.lblFineFeesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFeesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblFineFeesTitle.Location = new System.Drawing.Point(24, 149);
            this.lblFineFeesTitle.Name = "lblFineFeesTitle";
            this.lblFineFeesTitle.Size = new System.Drawing.Size(99, 20);
            this.lblFineFeesTitle.TabIndex = 159;
            this.lblFineFeesTitle.Text = "Fine Fees: ";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Presentation_Layer.Properties.Resources.Fees32;
            this.pictureBox8.Location = new System.Drawing.Point(187, 145);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 158;
            this.pictureBox8.TabStop = false;
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.ForeColor = System.Drawing.Color.Black;
            this.lblFineFees.Location = new System.Drawing.Point(225, 146);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(40, 24);
            this.lblFineFees.TabIndex = 160;
            this.lblFineFees.Text = "???";
            // 
            // lblCreatedByTitle
            // 
            this.lblCreatedByTitle.AutoSize = true;
            this.lblCreatedByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByTitle.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByTitle.Location = new System.Drawing.Point(357, 112);
            this.lblCreatedByTitle.Name = "lblCreatedByTitle";
            this.lblCreatedByTitle.Size = new System.Drawing.Size(108, 20);
            this.lblCreatedByTitle.TabIndex = 156;
            this.lblCreatedByTitle.Text = "Created By: ";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pictureBox7.Location = new System.Drawing.Point(547, 42);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 155;
            this.pictureBox7.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(588, 109);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(40, 24);
            this.lblCreatedBy.TabIndex = 157;
            this.lblCreatedBy.Text = "???";
            // 
            // lblLicenseIDTitle
            // 
            this.lblLicenseIDTitle.AutoSize = true;
            this.lblLicenseIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseIDTitle.Location = new System.Drawing.Point(357, 44);
            this.lblLicenseIDTitle.Name = "lblLicenseIDTitle";
            this.lblLicenseIDTitle.Size = new System.Drawing.Size(100, 20);
            this.lblLicenseIDTitle.TabIndex = 153;
            this.lblLicenseIDTitle.Text = "License ID:";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseID.Location = new System.Drawing.Point(588, 44);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(40, 24);
            this.lblLicenseID.TabIndex = 154;
            this.lblLicenseID.Text = "???";
            // 
            // lblDetainDateTitle
            // 
            this.lblDetainDateTitle.AutoSize = true;
            this.lblDetainDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDateTitle.ForeColor = System.Drawing.Color.Black;
            this.lblDetainDateTitle.Location = new System.Drawing.Point(24, 81);
            this.lblDetainDateTitle.Name = "lblDetainDateTitle";
            this.lblDetainDateTitle.Size = new System.Drawing.Size(116, 20);
            this.lblDetainDateTitle.TabIndex = 150;
            this.lblDetainDateTitle.Text = "Detain Date: ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pictureBox5.Location = new System.Drawing.Point(547, 78);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 149;
            this.pictureBox5.TabStop = false;
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.ForeColor = System.Drawing.Color.Black;
            this.lblDetainDate.Location = new System.Drawing.Point(225, 77);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(40, 24);
            this.lblDetainDate.TabIndex = 151;
            this.lblDetainDate.Text = "???";
            // 
            // lblAppFeesTitle
            // 
            this.lblAppFeesTitle.AutoSize = true;
            this.lblAppFeesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFeesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblAppFeesTitle.Location = new System.Drawing.Point(24, 112);
            this.lblAppFeesTitle.Name = "lblAppFeesTitle";
            this.lblAppFeesTitle.Size = new System.Drawing.Size(153, 20);
            this.lblAppFeesTitle.TabIndex = 147;
            this.lblAppFeesTitle.Text = "Application Fees: ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Presentation_Layer.Properties.Resources.Fees32;
            this.pictureBox4.Location = new System.Drawing.Point(187, 109);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 146;
            this.pictureBox4.TabStop = false;
            // 
            // lblApplicationFee
            // 
            this.lblApplicationFee.AutoSize = true;
            this.lblApplicationFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFee.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFee.Location = new System.Drawing.Point(225, 109);
            this.lblApplicationFee.Name = "lblApplicationFee";
            this.lblApplicationFee.Size = new System.Drawing.Size(40, 24);
            this.lblApplicationFee.TabIndex = 148;
            this.lblApplicationFee.Text = "???";
            // 
            // lblApplicationIDTitle
            // 
            this.lblApplicationIDTitle.AutoSize = true;
            this.lblApplicationIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationIDTitle.Location = new System.Drawing.Point(357, 81);
            this.lblApplicationIDTitle.Name = "lblApplicationIDTitle";
            this.lblApplicationIDTitle.Size = new System.Drawing.Size(127, 20);
            this.lblApplicationIDTitle.TabIndex = 144;
            this.lblApplicationIDTitle.Text = "Application ID:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentation_Layer.Properties.Resources.Key;
            this.pictureBox3.Location = new System.Drawing.Point(547, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 143;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.Calendar;
            this.pictureBox1.Location = new System.Drawing.Point(187, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationID.Location = new System.Drawing.Point(588, 77);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(40, 24);
            this.lblApplicationID.TabIndex = 139;
            this.lblApplicationID.Text = "???";
            // 
            // lblDetainIDTitle
            // 
            this.lblDetainIDTitle.AutoSize = true;
            this.lblDetainIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblDetainIDTitle.Location = new System.Drawing.Point(24, 44);
            this.lblDetainIDTitle.Name = "lblDetainIDTitle";
            this.lblDetainIDTitle.Size = new System.Drawing.Size(91, 20);
            this.lblDetainIDTitle.TabIndex = 135;
            this.lblDetainIDTitle.Text = "Detain ID:";
            // 
            // pbUserNo
            // 
            this.pbUserNo.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pbUserNo.Location = new System.Drawing.Point(187, 42);
            this.pbUserNo.Name = "pbUserNo";
            this.pbUserNo.Size = new System.Drawing.Size(25, 25);
            this.pbUserNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserNo.TabIndex = 134;
            this.pbUserNo.TabStop = false;
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.ForeColor = System.Drawing.Color.Black;
            this.lblDetainID.Location = new System.Drawing.Point(225, 40);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(40, 24);
            this.lblDetainID.TabIndex = 136;
            this.lblDetainID.Text = "???";
            // 
            // frmReleaseLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucLicenseCard1);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblReleaseLicense);
            this.Name = "frmReleaseLicense";
            this.Text = "Release License";
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.LinkLabel lblShowLicenseInfo;
        private System.Windows.Forms.Button lblSave;
        private System.Windows.Forms.Button btnClose;
        private UserControls.LicenseUserControls.ucLicenseCard ucLicenseCard1;
        private System.Windows.Forms.LinkLabel lblShowLicenseHistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReleaseLicense;
        private System.Windows.Forms.Label lblTotalFeesTitle;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblFineFeesTitle;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label lblCreatedByTitle;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblLicenseIDTitle;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblDetainDateTitle;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblAppFeesTitle;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblApplicationFee;
        private System.Windows.Forms.Label lblApplicationIDTitle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblDetainIDTitle;
        private System.Windows.Forms.PictureBox pbUserNo;
        private System.Windows.Forms.Label lblDetainID;
    }
}