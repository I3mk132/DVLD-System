namespace Presentation_Layer.LicenseForms
{
    partial class frmIssueInterLicense
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCreatedByTitle = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblILLicenseIDTitle = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblILLicenseID = new System.Windows.Forms.Label();
            this.lblApplicationDateTitle = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblFeesTitle = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblLocalLicenseIDTitle = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblExpirationDateTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblIssueDateTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLocalLicenseID = new System.Windows.Forms.Label();
            this.lblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lblILAppIDTitle = new System.Windows.Forms.Label();
            this.pbUserNo = new System.Windows.Forms.PictureBox();
            this.lblILApplicationID = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ucLicenseCard1 = new Presentation_Layer.UserControls.LicenseUserControls.ucLicenseCard();
            this.gbFilter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.White;
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.lblFilter);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Location = new System.Drawing.Point(53, 27);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(714, 80);
            this.gbFilter.TabIndex = 19;
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
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(176, 31);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(153, 26);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(14, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 240);
            this.panel1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCreatedByTitle);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.lblILLicenseIDTitle);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.lblILLicenseID);
            this.groupBox1.Controls.Add(this.lblApplicationDateTitle);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.lblApplicationDate);
            this.groupBox1.Controls.Add(this.lblFeesTitle);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.lblFees);
            this.groupBox1.Controls.Add(this.lblLocalLicenseIDTitle);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.lblIssueDate);
            this.groupBox1.Controls.Add(this.lblExpirationDateTitle);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblExpirationDate);
            this.groupBox1.Controls.Add(this.lblIssueDateTitle);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblLocalLicenseID);
            this.groupBox1.Controls.Add(this.lblILAppIDTitle);
            this.groupBox1.Controls.Add(this.pbUserNo);
            this.groupBox1.Controls.Add(this.lblILApplicationID);
            this.groupBox1.Location = new System.Drawing.Point(15, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 227);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCreatedByTitle
            // 
            this.lblCreatedByTitle.AutoSize = true;
            this.lblCreatedByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByTitle.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByTitle.Location = new System.Drawing.Point(353, 153);
            this.lblCreatedByTitle.Name = "lblCreatedByTitle";
            this.lblCreatedByTitle.Size = new System.Drawing.Size(108, 20);
            this.lblCreatedByTitle.TabIndex = 123;
            this.lblCreatedByTitle.Text = "Created By: ";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pictureBox7.Location = new System.Drawing.Point(513, 30);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 122;
            this.pictureBox7.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(554, 144);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(40, 24);
            this.lblCreatedBy.TabIndex = 124;
            this.lblCreatedBy.Text = "???";
            // 
            // lblILLicenseIDTitle
            // 
            this.lblILLicenseIDTitle.AutoSize = true;
            this.lblILLicenseIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblILLicenseIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblILLicenseIDTitle.Location = new System.Drawing.Point(353, 35);
            this.lblILLicenseIDTitle.Name = "lblILLicenseIDTitle";
            this.lblILLicenseIDTitle.Size = new System.Drawing.Size(126, 20);
            this.lblILLicenseIDTitle.TabIndex = 120;
            this.lblILLicenseIDTitle.Text = "I.L.License ID:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Presentation_Layer.Properties.Resources.Calendar;
            this.pictureBox6.Location = new System.Drawing.Point(183, 109);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 119;
            this.pictureBox6.TabStop = false;
            // 
            // lblILLicenseID
            // 
            this.lblILLicenseID.AutoSize = true;
            this.lblILLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblILLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblILLicenseID.Location = new System.Drawing.Point(554, 31);
            this.lblILLicenseID.Name = "lblILLicenseID";
            this.lblILLicenseID.Size = new System.Drawing.Size(40, 24);
            this.lblILLicenseID.TabIndex = 121;
            this.lblILLicenseID.Text = "???";
            // 
            // lblApplicationDateTitle
            // 
            this.lblApplicationDateTitle.AutoSize = true;
            this.lblApplicationDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDateTitle.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDateTitle.Location = new System.Drawing.Point(20, 76);
            this.lblApplicationDateTitle.Name = "lblApplicationDateTitle";
            this.lblApplicationDateTitle.Size = new System.Drawing.Size(152, 20);
            this.lblApplicationDateTitle.TabIndex = 117;
            this.lblApplicationDateTitle.Text = "Application Date: ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pictureBox5.Location = new System.Drawing.Point(513, 71);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 116;
            this.pictureBox5.TabStop = false;
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDate.Location = new System.Drawing.Point(221, 75);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(40, 24);
            this.lblApplicationDate.TabIndex = 118;
            this.lblApplicationDate.Text = "???";
            // 
            // lblFeesTitle
            // 
            this.lblFeesTitle.AutoSize = true;
            this.lblFeesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblFeesTitle.Location = new System.Drawing.Point(20, 153);
            this.lblFeesTitle.Name = "lblFeesTitle";
            this.lblFeesTitle.Size = new System.Drawing.Size(59, 20);
            this.lblFeesTitle.TabIndex = 114;
            this.lblFeesTitle.Text = "Fees: ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Presentation_Layer.Properties.Resources.Fees32;
            this.pictureBox4.Location = new System.Drawing.Point(183, 148);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 113;
            this.pictureBox4.TabStop = false;
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.Black;
            this.lblFees.Location = new System.Drawing.Point(221, 150);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(40, 24);
            this.lblFees.TabIndex = 115;
            this.lblFees.Text = "???";
            // 
            // lblLocalLicenseIDTitle
            // 
            this.lblLocalLicenseIDTitle.AutoSize = true;
            this.lblLocalLicenseIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblLocalLicenseIDTitle.Location = new System.Drawing.Point(353, 76);
            this.lblLocalLicenseIDTitle.Name = "lblLocalLicenseIDTitle";
            this.lblLocalLicenseIDTitle.Size = new System.Drawing.Size(148, 20);
            this.lblLocalLicenseIDTitle.TabIndex = 111;
            this.lblLocalLicenseIDTitle.Text = "Local License ID:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentation_Layer.Properties.Resources.Key;
            this.pictureBox3.Location = new System.Drawing.Point(513, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 110;
            this.pictureBox3.TabStop = false;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.Black;
            this.lblIssueDate.Location = new System.Drawing.Point(221, 111);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(40, 24);
            this.lblIssueDate.TabIndex = 112;
            this.lblIssueDate.Text = "???";
            // 
            // lblExpirationDateTitle
            // 
            this.lblExpirationDateTitle.AutoSize = true;
            this.lblExpirationDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDateTitle.ForeColor = System.Drawing.Color.Black;
            this.lblExpirationDateTitle.Location = new System.Drawing.Point(353, 114);
            this.lblExpirationDateTitle.Name = "lblExpirationDateTitle";
            this.lblExpirationDateTitle.Size = new System.Drawing.Size(138, 20);
            this.lblExpirationDateTitle.TabIndex = 108;
            this.lblExpirationDateTitle.Text = "Expiration Date:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentation_Layer.Properties.Resources.Calendar;
            this.pictureBox2.Location = new System.Drawing.Point(513, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.ForeColor = System.Drawing.Color.Black;
            this.lblExpirationDate.Location = new System.Drawing.Point(554, 110);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(40, 24);
            this.lblExpirationDate.TabIndex = 109;
            this.lblExpirationDate.Text = "???";
            // 
            // lblIssueDateTitle
            // 
            this.lblIssueDateTitle.AutoSize = true;
            this.lblIssueDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDateTitle.ForeColor = System.Drawing.Color.Black;
            this.lblIssueDateTitle.Location = new System.Drawing.Point(20, 114);
            this.lblIssueDateTitle.Name = "lblIssueDateTitle";
            this.lblIssueDateTitle.Size = new System.Drawing.Size(102, 20);
            this.lblIssueDateTitle.TabIndex = 105;
            this.lblIssueDateTitle.Text = "Issue Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.Calendar;
            this.pictureBox1.Location = new System.Drawing.Point(183, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // lblLocalLicenseID
            // 
            this.lblLocalLicenseID.AutoSize = true;
            this.lblLocalLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblLocalLicenseID.Location = new System.Drawing.Point(554, 72);
            this.lblLocalLicenseID.Name = "lblLocalLicenseID";
            this.lblLocalLicenseID.Size = new System.Drawing.Size(40, 24);
            this.lblLocalLicenseID.TabIndex = 106;
            this.lblLocalLicenseID.Text = "???";
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.AutoSize = true;
            this.lblShowLicenseHistory.Enabled = false;
            this.lblShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(25, 718);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(196, 24);
            this.lblShowLicenseHistory.TabIndex = 103;
            this.lblShowLicenseHistory.TabStop = true;
            this.lblShowLicenseHistory.Text = "Show License History.";
            this.lblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseHistory_LinkClicked);
            // 
            // lblILAppIDTitle
            // 
            this.lblILAppIDTitle.AutoSize = true;
            this.lblILAppIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblILAppIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblILAppIDTitle.Location = new System.Drawing.Point(20, 35);
            this.lblILAppIDTitle.Name = "lblILAppIDTitle";
            this.lblILAppIDTitle.Size = new System.Drawing.Size(153, 20);
            this.lblILAppIDTitle.TabIndex = 99;
            this.lblILAppIDTitle.Text = "I.L.Application ID:";
            // 
            // pbUserNo
            // 
            this.pbUserNo.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pbUserNo.Location = new System.Drawing.Point(183, 30);
            this.pbUserNo.Name = "pbUserNo";
            this.pbUserNo.Size = new System.Drawing.Size(25, 25);
            this.pbUserNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserNo.TabIndex = 97;
            this.pbUserNo.TabStop = false;
            // 
            // lblILApplicationID
            // 
            this.lblILApplicationID.AutoSize = true;
            this.lblILApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblILApplicationID.ForeColor = System.Drawing.Color.Black;
            this.lblILApplicationID.Location = new System.Drawing.Point(221, 32);
            this.lblILApplicationID.Name = "lblILApplicationID";
            this.lblILApplicationID.Size = new System.Drawing.Size(40, 24);
            this.lblILApplicationID.TabIndex = 100;
            this.lblILApplicationID.Text = "???";
            // 
            // lblSave
            // 
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Enabled = false;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.Image = global::Presentation_Layer.Properties.Resources.Save32;
            this.lblSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSave.Location = new System.Drawing.Point(596, 711);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(196, 40);
            this.lblSave.TabIndex = 146;
            this.lblSave.Text = "Issue License";
            this.lblSave.UseVisualStyleBackColor = true;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(456, 711);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 145;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.AutoSize = true;
            this.lblShowLicenseInfo.Enabled = false;
            this.lblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(241, 718);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(169, 24);
            this.lblShowLicenseInfo.TabIndex = 147;
            this.lblShowLicenseInfo.TabStop = true;
            this.lblShowLicenseInfo.Text = "Show License Info.";
            // 
            // ucLicenseCard1
            // 
            this.ucLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ucLicenseCard1.Location = new System.Drawing.Point(12, 113);
            this.ucLicenseCard1.Name = "ucLicenseCard1";
            this.ucLicenseCard1.Padding = new System.Windows.Forms.Padding(5);
            this.ucLicenseCard1.Size = new System.Drawing.Size(780, 333);
            this.ucLicenseCard1.TabIndex = 20;
            // 
            // frmIssueInterLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(808, 763);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucLicenseCard1);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Name = "frmIssueInterLicense";
            this.Text = "frmIssueInterLicense";
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFind;
        private UserControls.LicenseUserControls.ucLicenseCard ucLicenseCard1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCreatedByTitle;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblILLicenseIDTitle;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblILLicenseID;
        private System.Windows.Forms.Label lblApplicationDateTitle;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblFeesTitle;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblLocalLicenseIDTitle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblExpirationDateTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblIssueDateTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLocalLicenseID;
        private System.Windows.Forms.LinkLabel lblShowLicenseHistory;
        private System.Windows.Forms.Label lblILAppIDTitle;
        private System.Windows.Forms.PictureBox pbUserNo;
        private System.Windows.Forms.Label lblILApplicationID;
        private System.Windows.Forms.Button lblSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lblShowLicenseInfo;
    }
}