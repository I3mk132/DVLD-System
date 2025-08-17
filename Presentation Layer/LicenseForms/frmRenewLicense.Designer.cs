namespace Presentation_Layer.LicenseForms
{
    partial class frmRenewLicense
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
            this.lblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lblSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lblCreatedByTitle = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblNewLicenseIDTitle = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblNewLicenseID = new System.Windows.Forms.Label();
            this.lblApplicationDateTitle = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblAppFeesTitle = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ucLicenseCard1 = new Presentation_Layer.UserControls.LicenseUserControls.ucLicenseCard();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotesTitle = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblTotalFeesTitle = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblLicenseFeesTitle = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblLicenseFees = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblOldLicenseIDTitle = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblExpirationDateTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblIssueDateTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblRLAppIDTitle = new System.Windows.Forms.Label();
            this.pbUserNo = new System.Windows.Forms.PictureBox();
            this.lblRLApplicationID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRenewLicense = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.AutoSize = true;
            this.lblShowLicenseInfo.Enabled = false;
            this.lblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(237, 798);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(169, 24);
            this.lblShowLicenseInfo.TabIndex = 154;
            this.lblShowLicenseInfo.TabStop = true;
            this.lblShowLicenseInfo.Text = "Show License Info.";
            this.lblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseInfo_LinkClicked);
            // 
            // lblSave
            // 
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Enabled = false;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.Image = global::Presentation_Layer.Properties.Resources.Save32;
            this.lblSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSave.Location = new System.Drawing.Point(592, 791);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(196, 40);
            this.lblSave.TabIndex = 153;
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
            this.btnClose.Location = new System.Drawing.Point(452, 791);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 152;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.AutoSize = true;
            this.lblShowLicenseHistory.Enabled = false;
            this.lblShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(21, 798);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(196, 24);
            this.lblShowLicenseHistory.TabIndex = 151;
            this.lblShowLicenseHistory.TabStop = true;
            this.lblShowLicenseHistory.Text = "Show License History.";
            this.lblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseHistory_LinkClicked);
            // 
            // lblCreatedByTitle
            // 
            this.lblCreatedByTitle.AutoSize = true;
            this.lblCreatedByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByTitle.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByTitle.Location = new System.Drawing.Point(353, 141);
            this.lblCreatedByTitle.Name = "lblCreatedByTitle";
            this.lblCreatedByTitle.Size = new System.Drawing.Size(108, 20);
            this.lblCreatedByTitle.TabIndex = 123;
            this.lblCreatedByTitle.Text = "Created By: ";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pictureBox7.Location = new System.Drawing.Point(543, 30);
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
            this.lblCreatedBy.Location = new System.Drawing.Point(584, 138);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(40, 24);
            this.lblCreatedBy.TabIndex = 124;
            this.lblCreatedBy.Text = "???";
            // 
            // lblNewLicenseIDTitle
            // 
            this.lblNewLicenseIDTitle.AutoSize = true;
            this.lblNewLicenseIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLicenseIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblNewLicenseIDTitle.Location = new System.Drawing.Point(353, 32);
            this.lblNewLicenseIDTitle.Name = "lblNewLicenseIDTitle";
            this.lblNewLicenseIDTitle.Size = new System.Drawing.Size(180, 20);
            this.lblNewLicenseIDTitle.TabIndex = 120;
            this.lblNewLicenseIDTitle.Text = "Renewed License ID:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Presentation_Layer.Properties.Resources.Calendar;
            this.pictureBox6.Location = new System.Drawing.Point(183, 102);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 119;
            this.pictureBox6.TabStop = false;
            // 
            // lblNewLicenseID
            // 
            this.lblNewLicenseID.AutoSize = true;
            this.lblNewLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblNewLicenseID.Location = new System.Drawing.Point(584, 32);
            this.lblNewLicenseID.Name = "lblNewLicenseID";
            this.lblNewLicenseID.Size = new System.Drawing.Size(40, 24);
            this.lblNewLicenseID.TabIndex = 121;
            this.lblNewLicenseID.Text = "???";
            // 
            // lblApplicationDateTitle
            // 
            this.lblApplicationDateTitle.AutoSize = true;
            this.lblApplicationDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDateTitle.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDateTitle.Location = new System.Drawing.Point(20, 69);
            this.lblApplicationDateTitle.Name = "lblApplicationDateTitle";
            this.lblApplicationDateTitle.Size = new System.Drawing.Size(152, 20);
            this.lblApplicationDateTitle.TabIndex = 117;
            this.lblApplicationDateTitle.Text = "Application Date: ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pictureBox5.Location = new System.Drawing.Point(543, 66);
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
            this.lblApplicationDate.Location = new System.Drawing.Point(221, 65);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(40, 24);
            this.lblApplicationDate.TabIndex = 118;
            this.lblApplicationDate.Text = "???";
            // 
            // lblAppFeesTitle
            // 
            this.lblAppFeesTitle.AutoSize = true;
            this.lblAppFeesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFeesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblAppFeesTitle.Location = new System.Drawing.Point(20, 141);
            this.lblAppFeesTitle.Name = "lblAppFeesTitle";
            this.lblAppFeesTitle.Size = new System.Drawing.Size(153, 20);
            this.lblAppFeesTitle.TabIndex = 114;
            this.lblAppFeesTitle.Text = "Application Fees: ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Presentation_Layer.Properties.Resources.Fees32;
            this.pictureBox4.Location = new System.Drawing.Point(183, 138);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 113;
            this.pictureBox4.TabStop = false;
            // 
            // ucLicenseCard1
            // 
            this.ucLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ucLicenseCard1.Location = new System.Drawing.Point(8, 136);
            this.ucLicenseCard1.Name = "ucLicenseCard1";
            this.ucLicenseCard1.Padding = new System.Windows.Forms.Padding(5);
            this.ucLicenseCard1.Size = new System.Drawing.Size(780, 333);
            this.ucLicenseCard1.TabIndex = 149;
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.White;
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.lblFilter);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Location = new System.Drawing.Point(49, 50);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(714, 80);
            this.gbFilter.TabIndex = 148;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.lblNotesTitle);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.lblTotalFeesTitle);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.lblTotalFees);
            this.groupBox1.Controls.Add(this.lblLicenseFeesTitle);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.lblLicenseFees);
            this.groupBox1.Controls.Add(this.lblCreatedByTitle);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.lblNewLicenseIDTitle);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.lblNewLicenseID);
            this.groupBox1.Controls.Add(this.lblApplicationDateTitle);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.lblApplicationDate);
            this.groupBox1.Controls.Add(this.lblAppFeesTitle);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.lblApplicationFees);
            this.groupBox1.Controls.Add(this.lblOldLicenseIDTitle);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.lblIssueDate);
            this.groupBox1.Controls.Add(this.lblExpirationDateTitle);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblExpirationDate);
            this.groupBox1.Controls.Add(this.lblIssueDateTitle);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblOldLicenseID);
            this.groupBox1.Controls.Add(this.lblRLAppIDTitle);
            this.groupBox1.Controls.Add(this.pbUserNo);
            this.groupBox1.Controls.Add(this.lblRLApplicationID);
            this.groupBox1.Location = new System.Drawing.Point(15, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 282);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New License Application Info";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(225, 210);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(498, 55);
            this.txtNotes.TabIndex = 16;
            // 
            // lblNotesTitle
            // 
            this.lblNotesTitle.AutoSize = true;
            this.lblNotesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblNotesTitle.Location = new System.Drawing.Point(20, 215);
            this.lblNotesTitle.Name = "lblNotesTitle";
            this.lblNotesTitle.Size = new System.Drawing.Size(66, 20);
            this.lblNotesTitle.TabIndex = 132;
            this.lblNotesTitle.Text = "Notes: ";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Presentation_Layer.Properties.Resources.Title32;
            this.pictureBox10.Location = new System.Drawing.Point(183, 210);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(25, 25);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 131;
            this.pictureBox10.TabStop = false;
            // 
            // lblTotalFeesTitle
            // 
            this.lblTotalFeesTitle.AutoSize = true;
            this.lblTotalFeesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFeesTitle.Location = new System.Drawing.Point(353, 178);
            this.lblTotalFeesTitle.Name = "lblTotalFeesTitle";
            this.lblTotalFeesTitle.Size = new System.Drawing.Size(99, 20);
            this.lblTotalFeesTitle.TabIndex = 129;
            this.lblTotalFeesTitle.Text = "Total Fees:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Presentation_Layer.Properties.Resources.Fees32;
            this.pictureBox9.Location = new System.Drawing.Point(543, 174);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(25, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 128;
            this.pictureBox9.TabStop = false;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFees.Location = new System.Drawing.Point(584, 175);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(40, 24);
            this.lblTotalFees.TabIndex = 130;
            this.lblTotalFees.Text = "???";
            // 
            // lblLicenseFeesTitle
            // 
            this.lblLicenseFeesTitle.AutoSize = true;
            this.lblLicenseFeesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseFeesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseFeesTitle.Location = new System.Drawing.Point(20, 178);
            this.lblLicenseFeesTitle.Name = "lblLicenseFeesTitle";
            this.lblLicenseFeesTitle.Size = new System.Drawing.Size(126, 20);
            this.lblLicenseFeesTitle.TabIndex = 126;
            this.lblLicenseFeesTitle.Text = "License Fees: ";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Presentation_Layer.Properties.Resources.Fees32;
            this.pictureBox8.Location = new System.Drawing.Point(183, 174);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 125;
            this.pictureBox8.TabStop = false;
            // 
            // lblLicenseFees
            // 
            this.lblLicenseFees.AutoSize = true;
            this.lblLicenseFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseFees.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseFees.Location = new System.Drawing.Point(221, 175);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(40, 24);
            this.lblLicenseFees.TabIndex = 127;
            this.lblLicenseFees.Text = "???";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFees.Location = new System.Drawing.Point(221, 138);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(40, 24);
            this.lblApplicationFees.TabIndex = 115;
            this.lblApplicationFees.Text = "???";
            // 
            // lblOldLicenseIDTitle
            // 
            this.lblOldLicenseIDTitle.AutoSize = true;
            this.lblOldLicenseIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblOldLicenseIDTitle.Location = new System.Drawing.Point(353, 69);
            this.lblOldLicenseIDTitle.Name = "lblOldLicenseIDTitle";
            this.lblOldLicenseIDTitle.Size = new System.Drawing.Size(132, 20);
            this.lblOldLicenseIDTitle.TabIndex = 111;
            this.lblOldLicenseIDTitle.Text = "Old License ID:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentation_Layer.Properties.Resources.Key;
            this.pictureBox3.Location = new System.Drawing.Point(543, 138);
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
            this.lblIssueDate.Location = new System.Drawing.Point(221, 102);
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
            this.lblExpirationDateTitle.Location = new System.Drawing.Point(353, 105);
            this.lblExpirationDateTitle.Name = "lblExpirationDateTitle";
            this.lblExpirationDateTitle.Size = new System.Drawing.Size(138, 20);
            this.lblExpirationDateTitle.TabIndex = 108;
            this.lblExpirationDateTitle.Text = "Expiration Date:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentation_Layer.Properties.Resources.Calendar;
            this.pictureBox2.Location = new System.Drawing.Point(543, 102);
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
            this.lblExpirationDate.Location = new System.Drawing.Point(584, 105);
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
            this.lblIssueDateTitle.Location = new System.Drawing.Point(20, 105);
            this.lblIssueDateTitle.Name = "lblIssueDateTitle";
            this.lblIssueDateTitle.Size = new System.Drawing.Size(102, 20);
            this.lblIssueDateTitle.TabIndex = 105;
            this.lblIssueDateTitle.Text = "Issue Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.Calendar;
            this.pictureBox1.Location = new System.Drawing.Point(183, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblOldLicenseID.Location = new System.Drawing.Point(584, 65);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(40, 24);
            this.lblOldLicenseID.TabIndex = 106;
            this.lblOldLicenseID.Text = "???";
            // 
            // lblRLAppIDTitle
            // 
            this.lblRLAppIDTitle.AutoSize = true;
            this.lblRLAppIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLAppIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblRLAppIDTitle.Location = new System.Drawing.Point(20, 32);
            this.lblRLAppIDTitle.Name = "lblRLAppIDTitle";
            this.lblRLAppIDTitle.Size = new System.Drawing.Size(160, 20);
            this.lblRLAppIDTitle.TabIndex = 99;
            this.lblRLAppIDTitle.Text = "R.L.Application ID:";
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
            // lblRLApplicationID
            // 
            this.lblRLApplicationID.AutoSize = true;
            this.lblRLApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLApplicationID.ForeColor = System.Drawing.Color.Black;
            this.lblRLApplicationID.Location = new System.Drawing.Point(221, 28);
            this.lblRLApplicationID.Name = "lblRLApplicationID";
            this.lblRLApplicationID.Size = new System.Drawing.Size(40, 24);
            this.lblRLApplicationID.TabIndex = 100;
            this.lblRLApplicationID.Text = "???";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(10, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 300);
            this.panel1.TabIndex = 150;
            // 
            // lblRenewLicense
            // 
            this.lblRenewLicense.AutoSize = true;
            this.lblRenewLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewLicense.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRenewLicense.Location = new System.Drawing.Point(288, 9);
            this.lblRenewLicense.Name = "lblRenewLicense";
            this.lblRenewLicense.Size = new System.Drawing.Size(213, 31);
            this.lblRenewLicense.TabIndex = 155;
            this.lblRenewLicense.Text = "Renew License";
            // 
            // frmRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(800, 843);
            this.Controls.Add(this.lblRenewLicense);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.ucLicenseCard1);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.panel1);
            this.Name = "frmRenewLicense";
            this.Text = "Renew License";
            this.Load += new System.EventHandler(this.frmRenewLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblShowLicenseInfo;
        private System.Windows.Forms.Button lblSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lblShowLicenseHistory;
        private System.Windows.Forms.Label lblCreatedByTitle;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblNewLicenseIDTitle;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblNewLicenseID;
        private System.Windows.Forms.Label lblApplicationDateTitle;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblAppFeesTitle;
        private System.Windows.Forms.PictureBox pictureBox4;
        private UserControls.LicenseUserControls.ucLicenseCard ucLicenseCard1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblOldLicenseIDTitle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblExpirationDateTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblIssueDateTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblRLAppIDTitle;
        private System.Windows.Forms.PictureBox pbUserNo;
        private System.Windows.Forms.Label lblRLApplicationID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRenewLicense;
        private System.Windows.Forms.Label lblLicenseFeesTitle;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblLicenseFees;
        private System.Windows.Forms.Label lblNotesTitle;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblTotalFeesTitle;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.TextBox txtNotes;
    }
}