namespace Presentation_Layer.UserControls.ApplicationsUserControl
{
    partial class ucLDLApplications
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.dgvApplicationsList = new System.Windows.Forms.DataGridView();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmss2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmss1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbCancelled = new System.Windows.Forms.RadioButton();
            this.rbCompleted = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.cmss3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsiShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiSechduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiIssueDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationsList)).BeginInit();
            this.cms.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbFilter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRecordCount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvApplicationsList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 424);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblRecordCount.Location = new System.Drawing.Point(3, 391);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(155, 26);
            this.lblRecordCount.TabIndex = 16;
            this.lblRecordCount.Text = "# Records: -1";
            // 
            // dgvApplicationsList
            // 
            this.dgvApplicationsList.AllowUserToAddRows = false;
            this.dgvApplicationsList.AllowUserToDeleteRows = false;
            this.dgvApplicationsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvApplicationsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvApplicationsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicationsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplicationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationsList.ContextMenuStrip = this.cms;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplicationsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplicationsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApplicationsList.Location = new System.Drawing.Point(3, 89);
            this.dgvApplicationsList.MultiSelect = false;
            this.dgvApplicationsList.Name = "dgvApplicationsList";
            this.dgvApplicationsList.ReadOnly = true;
            this.dgvApplicationsList.Size = new System.Drawing.Size(790, 299);
            this.dgvApplicationsList.TabIndex = 15;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiShowApplicationDetails,
            this.cmss2,
            this.cmsiEdit,
            this.cmsiDelete,
            this.cmss1,
            this.cmsiCancelApplication,
            this.cmsiSechduleTests,
            this.cmsiIssueDrivingLicense,
            this.cmss3,
            this.cmsiShowLicense,
            this.cmsiShowPersonLicenseHistory});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(266, 326);
            // 
            // cmss2
            // 
            this.cmss2.Name = "cmss2";
            this.cmss2.Size = new System.Drawing.Size(262, 6);
            // 
            // cmss1
            // 
            this.cmss1.Name = "cmss1";
            this.cmss1.Size = new System.Drawing.Size(262, 6);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.SystemColors.Control;
            this.cbFilterBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilterBy.DropDownHeight = 220;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.IntegralHeight = false;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Username",
            "Person ID",
            "Fullname",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(134, 33);
            this.cbFilterBy.MaxDropDownItems = 11;
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(207, 28);
            this.cbFilterBy.TabIndex = 0;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.DimGray;
            this.lblFilter.Location = new System.Drawing.Point(22, 30);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(115, 26);
            this.lblFilter.TabIndex = 14;
            this.lblFilter.Text = "Filter By: ";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(369, 35);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(227, 26);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.SystemColors.Control;
            this.gbFilter.Controls.Add(this.rbNone);
            this.gbFilter.Controls.Add(this.rbCompleted);
            this.gbFilter.Controls.Add(this.rbCancelled);
            this.gbFilter.Controls.Add(this.rbNew);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Controls.Add(this.lblFilter);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(790, 80);
            this.gbFilter.TabIndex = 18;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNew.Location = new System.Drawing.Point(369, 34);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(58, 24);
            this.rbNew.TabIndex = 15;
            this.rbNew.TabStop = true;
            this.rbNew.Tag = "New";
            this.rbNew.Text = "New";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.Visible = false;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // rbCancelled
            // 
            this.rbCancelled.AutoSize = true;
            this.rbCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCancelled.Location = new System.Drawing.Point(433, 34);
            this.rbCancelled.Name = "rbCancelled";
            this.rbCancelled.Size = new System.Drawing.Size(97, 24);
            this.rbCancelled.TabIndex = 16;
            this.rbCancelled.TabStop = true;
            this.rbCancelled.Tag = "Cancelled";
            this.rbCancelled.Text = "Cancelled";
            this.rbCancelled.UseVisualStyleBackColor = true;
            this.rbCancelled.Visible = false;
            this.rbCancelled.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // rbCompleted
            // 
            this.rbCompleted.AutoSize = true;
            this.rbCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCompleted.Location = new System.Drawing.Point(536, 34);
            this.rbCompleted.Name = "rbCompleted";
            this.rbCompleted.Size = new System.Drawing.Size(104, 24);
            this.rbCompleted.TabIndex = 17;
            this.rbCompleted.TabStop = true;
            this.rbCompleted.Tag = "Completed";
            this.rbCompleted.Text = "Completed";
            this.rbCompleted.UseVisualStyleBackColor = true;
            this.rbCompleted.Visible = false;
            this.rbCompleted.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNone.Location = new System.Drawing.Point(646, 35);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(65, 24);
            this.rbNone.TabIndex = 18;
            this.rbNone.TabStop = true;
            this.rbNone.Tag = "None";
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.Visible = false;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // cmss3
            // 
            this.cmss3.Name = "cmss3";
            this.cmss3.Size = new System.Drawing.Size(262, 6);
            // 
            // cmsiShowApplicationDetails
            // 
            this.cmsiShowApplicationDetails.Image = global::Presentation_Layer.Properties.Resources.Clipboard32;
            this.cmsiShowApplicationDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiShowApplicationDetails.Name = "cmsiShowApplicationDetails";
            this.cmsiShowApplicationDetails.Size = new System.Drawing.Size(265, 38);
            this.cmsiShowApplicationDetails.Text = "Show Application Details";
            this.cmsiShowApplicationDetails.Click += new System.EventHandler(this.cmsiShowApplicationDetails_Click);
            // 
            // cmsiEdit
            // 
            this.cmsiEdit.Image = global::Presentation_Layer.Properties.Resources.EditPerson32;
            this.cmsiEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiEdit.Name = "cmsiEdit";
            this.cmsiEdit.Size = new System.Drawing.Size(265, 38);
            this.cmsiEdit.Text = "Edit";
            this.cmsiEdit.Click += new System.EventHandler(this.cmsiEdit_Click);
            // 
            // cmsiDelete
            // 
            this.cmsiDelete.Image = global::Presentation_Layer.Properties.Resources.DeletePerson32;
            this.cmsiDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiDelete.Name = "cmsiDelete";
            this.cmsiDelete.Size = new System.Drawing.Size(265, 38);
            this.cmsiDelete.Text = "Delete";
            this.cmsiDelete.Click += new System.EventHandler(this.cmsiDelete_Click);
            // 
            // cmsiCancelApplication
            // 
            this.cmsiCancelApplication.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.cmsiCancelApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiCancelApplication.Name = "cmsiCancelApplication";
            this.cmsiCancelApplication.Size = new System.Drawing.Size(265, 38);
            this.cmsiCancelApplication.Text = "Cancel Application";
            this.cmsiCancelApplication.Click += new System.EventHandler(this.cmsiCancelApplication_Click);
            // 
            // cmsiSechduleTests
            // 
            this.cmsiSechduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.cmsiSechduleTests.Image = global::Presentation_Layer.Properties.Resources.Test32;
            this.cmsiSechduleTests.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiSechduleTests.Name = "cmsiSechduleTests";
            this.cmsiSechduleTests.Size = new System.Drawing.Size(265, 38);
            this.cmsiSechduleTests.Text = "Sechdule Tests";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Test1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Test2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Test3";
            // 
            // cmsiIssueDrivingLicense
            // 
            this.cmsiIssueDrivingLicense.Enabled = false;
            this.cmsiIssueDrivingLicense.Image = global::Presentation_Layer.Properties.Resources.License32;
            this.cmsiIssueDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiIssueDrivingLicense.Name = "cmsiIssueDrivingLicense";
            this.cmsiIssueDrivingLicense.Size = new System.Drawing.Size(265, 38);
            this.cmsiIssueDrivingLicense.Text = "Issue Driving License ( First time )";
            // 
            // cmsiShowLicense
            // 
            this.cmsiShowLicense.Enabled = false;
            this.cmsiShowLicense.Image = global::Presentation_Layer.Properties.Resources.License32;
            this.cmsiShowLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiShowLicense.Name = "cmsiShowLicense";
            this.cmsiShowLicense.Size = new System.Drawing.Size(265, 38);
            this.cmsiShowLicense.Text = "Show License";
            // 
            // cmsiShowPersonLicenseHistory
            // 
            this.cmsiShowPersonLicenseHistory.Image = global::Presentation_Layer.Properties.Resources.PersonHistory32;
            this.cmsiShowPersonLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiShowPersonLicenseHistory.Name = "cmsiShowPersonLicenseHistory";
            this.cmsiShowPersonLicenseHistory.Size = new System.Drawing.Size(265, 38);
            this.cmsiShowPersonLicenseHistory.Text = "Show person license history";
            this.cmsiShowPersonLicenseHistory.Click += new System.EventHandler(this.cmsiShowPersonLicenseHistory_Click);
            // 
            // ucLDLApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucLDLApplications";
            this.Size = new System.Drawing.Size(796, 424);
            this.Load += new System.EventHandler(this.ucLDLApplications_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationsList)).EndInit();
            this.cms.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.DataGridView dgvApplicationsList;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem cmsiShowApplicationDetails;
        private System.Windows.Forms.ToolStripSeparator cmss2;
        private System.Windows.Forms.ToolStripMenuItem cmsiCancelApplication;
        private System.Windows.Forms.ToolStripMenuItem cmsiEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsiDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsiSechduleTests;
        private System.Windows.Forms.ToolStripSeparator cmss1;
        private System.Windows.Forms.ToolStripMenuItem cmsiIssueDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem cmsiShowLicense;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbCompleted;
        private System.Windows.Forms.RadioButton rbCancelled;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.ToolStripSeparator cmss3;
        private System.Windows.Forms.ToolStripMenuItem cmsiShowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}
