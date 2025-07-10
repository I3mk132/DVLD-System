namespace Presentation_Layer.UserControls
{
    partial class ucUsersList
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
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmss2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsiAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.cmss1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsiSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.ucUserFilter1 = new Presentation_Layer.UserControls.ucUserFilter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblRecordCount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvUsersList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucUserFilter1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 404);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblRecordCount.Location = new System.Drawing.Point(3, 371);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(155, 26);
            this.lblRecordCount.TabIndex = 16;
            this.lblRecordCount.Text = "# Records: -1";
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            this.dgvUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsersList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.ContextMenuStrip = this.cms;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsersList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsersList.Location = new System.Drawing.Point(3, 89);
            this.dgvUsersList.MultiSelect = false;
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            this.dgvUsersList.Size = new System.Drawing.Size(864, 279);
            this.dgvUsersList.TabIndex = 15;
            this.dgvUsersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersList_CellContentClick);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiShowDetails,
            this.cmss2,
            this.cmsiAddNewPerson,
            this.cmsiEdit,
            this.cmsiDelete,
            this.cmsiChangePassword,
            this.cmss1,
            this.cmsiSendEmail,
            this.cmsiPhoneCall});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(197, 304);
            // 
            // cmsiShowDetails
            // 
            this.cmsiShowDetails.Image = global::Presentation_Layer.Properties.Resources.Clipboard32;
            this.cmsiShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiShowDetails.Name = "cmsiShowDetails";
            this.cmsiShowDetails.Size = new System.Drawing.Size(196, 38);
            this.cmsiShowDetails.Text = "Show details";
            this.cmsiShowDetails.Click += new System.EventHandler(this.cmsiShowDetails_Click);
            // 
            // cmss2
            // 
            this.cmss2.Name = "cmss2";
            this.cmss2.Size = new System.Drawing.Size(193, 6);
            // 
            // cmsiAddNewPerson
            // 
            this.cmsiAddNewPerson.Image = global::Presentation_Layer.Properties.Resources.AddPerson32;
            this.cmsiAddNewPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiAddNewPerson.Name = "cmsiAddNewPerson";
            this.cmsiAddNewPerson.Size = new System.Drawing.Size(196, 38);
            this.cmsiAddNewPerson.Text = "Add new person";
            this.cmsiAddNewPerson.Click += new System.EventHandler(this.cmsiAddNewUser_Click);
            // 
            // cmsiEdit
            // 
            this.cmsiEdit.Image = global::Presentation_Layer.Properties.Resources.EditPerson32;
            this.cmsiEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiEdit.Name = "cmsiEdit";
            this.cmsiEdit.Size = new System.Drawing.Size(196, 38);
            this.cmsiEdit.Text = "Edit";
            this.cmsiEdit.Click += new System.EventHandler(this.cmsiEdit_Click);
            // 
            // cmsiDelete
            // 
            this.cmsiDelete.Image = global::Presentation_Layer.Properties.Resources.DeletePerson32;
            this.cmsiDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiDelete.Name = "cmsiDelete";
            this.cmsiDelete.Size = new System.Drawing.Size(196, 38);
            this.cmsiDelete.Text = "Delete";
            this.cmsiDelete.Click += new System.EventHandler(this.cmsiDelete_Click);
            // 
            // cmsiChangePassword
            // 
            this.cmsiChangePassword.Image = global::Presentation_Layer.Properties.Resources.password32;
            this.cmsiChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiChangePassword.Name = "cmsiChangePassword";
            this.cmsiChangePassword.Size = new System.Drawing.Size(196, 38);
            this.cmsiChangePassword.Text = "Change Password";
            this.cmsiChangePassword.Click += new System.EventHandler(this.cmsiChangePassword_Click);
            // 
            // cmss1
            // 
            this.cmss1.Name = "cmss1";
            this.cmss1.Size = new System.Drawing.Size(193, 6);
            // 
            // cmsiSendEmail
            // 
            this.cmsiSendEmail.Image = global::Presentation_Layer.Properties.Resources.SendMail32;
            this.cmsiSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiSendEmail.Name = "cmsiSendEmail";
            this.cmsiSendEmail.Size = new System.Drawing.Size(196, 38);
            this.cmsiSendEmail.Text = "Send Email";
            this.cmsiSendEmail.Click += new System.EventHandler(this.cmsiStillNotWorking_Click);
            // 
            // cmsiPhoneCall
            // 
            this.cmsiPhoneCall.Image = global::Presentation_Layer.Properties.Resources.phone32;
            this.cmsiPhoneCall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiPhoneCall.Name = "cmsiPhoneCall";
            this.cmsiPhoneCall.Size = new System.Drawing.Size(196, 38);
            this.cmsiPhoneCall.Text = "Phone Call";
            this.cmsiPhoneCall.Click += new System.EventHandler(this.cmsiStillNotWorking_Click);
            // 
            // ucUserFilter1
            // 
            this.ucUserFilter1.BackColor = System.Drawing.SystemColors.Control;
            this.ucUserFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserFilter1.Location = new System.Drawing.Point(3, 3);
            this.ucUserFilter1.Name = "ucUserFilter1";
            this.ucUserFilter1.Padding = new System.Windows.Forms.Padding(5);
            this.ucUserFilter1.Size = new System.Drawing.Size(864, 80);
            this.ucUserFilter1.TabIndex = 17;
            // 
            // ucUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucUsersList";
            this.Size = new System.Drawing.Size(870, 404);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.DataGridView dgvUsersList;
        private ucUserFilter ucUserFilter1;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem cmsiShowDetails;
        private System.Windows.Forms.ToolStripSeparator cmss2;
        private System.Windows.Forms.ToolStripMenuItem cmsiAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem cmsiEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsiDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsiChangePassword;
        private System.Windows.Forms.ToolStripSeparator cmss1;
        private System.Windows.Forms.ToolStripMenuItem cmsiSendEmail;
        private System.Windows.Forms.ToolStripMenuItem cmsiPhoneCall;
    }
}
