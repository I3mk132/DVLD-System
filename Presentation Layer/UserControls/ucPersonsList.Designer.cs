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
            this.dgvPersonsList = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmss1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmss2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsList)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonsList
            // 
            this.dgvPersonsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPersonsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPersonsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPersonsList.Location = new System.Drawing.Point(0, 42);
            this.dgvPersonsList.Name = "dgvPersonsList";
            this.dgvPersonsList.Size = new System.Drawing.Size(811, 266);
            this.dgvPersonsList.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(260, 8);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(227, 26);
            this.txtFilter.TabIndex = 8;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.SystemColors.Control;
            this.cbFilterBy.DropDownHeight = 220;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.IntegralHeight = false;
            this.cbFilterBy.Location = new System.Drawing.Point(119, 8);
            this.cbFilterBy.MaxDropDownItems = 11;
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(135, 28);
            this.cbFilterBy.TabIndex = 7;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.DimGray;
            this.lblFilter.Location = new System.Drawing.Point(14, 7);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(115, 26);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Filter By: ";
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
            // cmss1
            // 
            this.cmss1.Name = "cmss1";
            this.cmss1.Size = new System.Drawing.Size(173, 6);
            // 
            // cmss2
            // 
            this.cmss2.Name = "cmss2";
            this.cmss2.Size = new System.Drawing.Size(173, 6);
            // 
            // cmsiShowDetails
            // 
            this.cmsiShowDetails.Image = global::Presentation_Layer.Properties.Resources.Clipboard32;
            this.cmsiShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiShowDetails.Name = "cmsiShowDetails";
            this.cmsiShowDetails.Size = new System.Drawing.Size(176, 38);
            this.cmsiShowDetails.Text = "Show details";
            // 
            // cmsiAddNewPerson
            // 
            this.cmsiAddNewPerson.Image = global::Presentation_Layer.Properties.Resources.AddPerson32;
            this.cmsiAddNewPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiAddNewPerson.Name = "cmsiAddNewPerson";
            this.cmsiAddNewPerson.Size = new System.Drawing.Size(176, 38);
            this.cmsiAddNewPerson.Text = "Add new person";
            // 
            // cmsiEdit
            // 
            this.cmsiEdit.Image = global::Presentation_Layer.Properties.Resources.EditPerson32;
            this.cmsiEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiEdit.Name = "cmsiEdit";
            this.cmsiEdit.Size = new System.Drawing.Size(176, 38);
            this.cmsiEdit.Text = "Edit";
            // 
            // cmsiDelete
            // 
            this.cmsiDelete.Image = global::Presentation_Layer.Properties.Resources.DeletePerson32;
            this.cmsiDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiDelete.Name = "cmsiDelete";
            this.cmsiDelete.Size = new System.Drawing.Size(176, 38);
            this.cmsiDelete.Text = "Delete";
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
            // ucPersonsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.dgvPersonsList);
            this.Name = "ucPersonsList";
            this.Size = new System.Drawing.Size(811, 308);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsList)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonsList;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem cmsiShowDetails;
        private System.Windows.Forms.ToolStripSeparator cmss2;
        private System.Windows.Forms.ToolStripMenuItem cmsiAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem cmsiEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsiDelete;
        private System.Windows.Forms.ToolStripSeparator cmss1;
        private System.Windows.Forms.ToolStripMenuItem cmsiSendEmail;
        private System.Windows.Forms.ToolStripMenuItem cmsiPhoneCall;
    }
}
