namespace Presentation_Layer.UserControls
{
    partial class ucPersonsList
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
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmss2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsiAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmss1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsiSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgvPersonsList = new System.Windows.Forms.DataGridView();
            this.cms.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsList)).BeginInit();
            this.SuspendLayout();
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiShowDetails,
            this.cmss2,
            this.cmsiAddNewPerson,
            this.cmsiEdit,
            this.cmsiDelete,
            this.cmss1,
            this.cmsiSendEmail,
            this.cmsiPhoneCall});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(177, 244);
            // 
            // cmsiShowDetails
            // 
            this.cmsiShowDetails.Image = global::Presentation_Layer.Properties.Resources.Clipboard32;
            this.cmsiShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiShowDetails.Name = "cmsiShowDetails";
            this.cmsiShowDetails.Size = new System.Drawing.Size(176, 38);
            this.cmsiShowDetails.Text = "Show details";
            this.cmsiShowDetails.Click += new System.EventHandler(this.cmsiShowDetails_Click);
            // 
            // cmss2
            // 
            this.cmss2.Name = "cmss2";
            this.cmss2.Size = new System.Drawing.Size(173, 6);
            // 
            // cmsiAddNewPerson
            // 
            this.cmsiAddNewPerson.Image = global::Presentation_Layer.Properties.Resources.AddPerson32;
            this.cmsiAddNewPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiAddNewPerson.Name = "cmsiAddNewPerson";
            this.cmsiAddNewPerson.Size = new System.Drawing.Size(176, 38);
            this.cmsiAddNewPerson.Text = "Add new person";
            this.cmsiAddNewPerson.Click += new System.EventHandler(this.cmsiAddNewPerson_Click);
            // 
            // cmsiEdit
            // 
            this.cmsiEdit.Image = global::Presentation_Layer.Properties.Resources.EditPerson32;
            this.cmsiEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiEdit.Name = "cmsiEdit";
            this.cmsiEdit.Size = new System.Drawing.Size(176, 38);
            this.cmsiEdit.Text = "Edit";
            this.cmsiEdit.Click += new System.EventHandler(this.cmsiEdit_Click);
            // 
            // cmsiDelete
            // 
            this.cmsiDelete.Image = global::Presentation_Layer.Properties.Resources.DeletePerson32;
            this.cmsiDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiDelete.Name = "cmsiDelete";
            this.cmsiDelete.Size = new System.Drawing.Size(176, 38);
            this.cmsiDelete.Text = "Delete";
            this.cmsiDelete.Click += new System.EventHandler(this.cmsiDelete_Click);
            // 
            // cmss1
            // 
            this.cmss1.Name = "cmss1";
            this.cmss1.Size = new System.Drawing.Size(173, 6);
            // 
            // cmsiSendEmail
            // 
            this.cmsiSendEmail.Image = global::Presentation_Layer.Properties.Resources.SendMail32;
            this.cmsiSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiSendEmail.Name = "cmsiSendEmail";
            this.cmsiSendEmail.Size = new System.Drawing.Size(176, 38);
            this.cmsiSendEmail.Text = "Send Email";
            // 
            // cmsiPhoneCall
            // 
            this.cmsiPhoneCall.Image = global::Presentation_Layer.Properties.Resources.phone32;
            this.cmsiPhoneCall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiPhoneCall.Name = "cmsiPhoneCall";
            this.cmsiPhoneCall.Size = new System.Drawing.Size(176, 38);
            this.cmsiPhoneCall.Text = "Phone Call";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblRecordCount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvPersonsList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 340);
            this.tableLayoutPanel1.TabIndex = 10;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblRecordCount.Location = new System.Drawing.Point(3, 307);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(155, 26);
            this.lblRecordCount.TabIndex = 16;
            this.lblRecordCount.Text = "# Records: -1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.52174F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.00621F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.47205F));
            this.tableLayoutPanel2.Controls.Add(this.cbFilterBy, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFilter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtFilter, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(805, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
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
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
            this.cbFilterBy.Location = new System.Drawing.Point(136, 3);
            this.cbFilterBy.MaxDropDownItems = 11;
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(135, 28);
            this.cbFilterBy.TabIndex = 0;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.DimGray;
            this.lblFilter.Location = new System.Drawing.Point(3, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(115, 26);
            this.lblFilter.TabIndex = 11;
            this.lblFilter.Text = "Filter By: ";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(288, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(227, 26);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dgvPersonsList
            // 
            this.dgvPersonsList.AllowUserToAddRows = false;
            this.dgvPersonsList.AllowUserToDeleteRows = false;
            this.dgvPersonsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPersonsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPersonsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonsList.ContextMenuStrip = this.cms;
            this.dgvPersonsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonsList.Location = new System.Drawing.Point(3, 43);
            this.dgvPersonsList.MultiSelect = false;
            this.dgvPersonsList.Name = "dgvPersonsList";
            this.dgvPersonsList.ReadOnly = true;
            this.dgvPersonsList.Size = new System.Drawing.Size(805, 261);
            this.dgvPersonsList.TabIndex = 2;
            this.dgvPersonsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonsList_CellContentClick);
            // 
            // ucPersonsList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucPersonsList";
            this.Size = new System.Drawing.Size(811, 340);
            this.cms.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem cmsiShowDetails;
        private System.Windows.Forms.ToolStripSeparator cmss2;
        private System.Windows.Forms.ToolStripMenuItem cmsiAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem cmsiEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsiDelete;
        private System.Windows.Forms.ToolStripSeparator cmss1;
        private System.Windows.Forms.ToolStripMenuItem cmsiSendEmail;
        private System.Windows.Forms.ToolStripMenuItem cmsiPhoneCall;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvPersonsList;
        private System.Windows.Forms.Label lblRecordCount;
    }
}
