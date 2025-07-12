namespace Presentation_Layer.ApplicationForms
{
    partial class frmApplicationTypes
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
            this.components = new System.ComponentModel.Container();
            this.lblApplicationTypes = new System.Windows.Forms.Label();
            this.dgvApplicationTypes = new System.Windows.Forms.DataGridView();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
            this.cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApplicationTypes
            // 
            this.lblApplicationTypes.AutoSize = true;
            this.lblApplicationTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTypes.ForeColor = System.Drawing.Color.Firebrick;
            this.lblApplicationTypes.Location = new System.Drawing.Point(154, 203);
            this.lblApplicationTypes.Name = "lblApplicationTypes";
            this.lblApplicationTypes.Size = new System.Drawing.Size(287, 37);
            this.lblApplicationTypes.TabIndex = 6;
            this.lblApplicationTypes.Text = "Application Types";
            // 
            // dgvApplicationTypes
            // 
            this.dgvApplicationTypes.AllowUserToAddRows = false;
            this.dgvApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvApplicationTypes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvApplicationTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationTypes.ContextMenuStrip = this.cms;
            this.dgvApplicationTypes.Location = new System.Drawing.Point(12, 253);
            this.dgvApplicationTypes.MultiSelect = false;
            this.dgvApplicationTypes.Name = "dgvApplicationTypes";
            this.dgvApplicationTypes.ReadOnly = true;
            this.dgvApplicationTypes.Size = new System.Drawing.Size(575, 316);
            this.dgvApplicationTypes.TabIndex = 7;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiEdit});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(111, 42);
            // 
            // cmsiEdit
            // 
            this.cmsiEdit.Image = global::Presentation_Layer.Properties.Resources.EditPerson32;
            this.cmsiEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsiEdit.Name = "cmsiEdit";
            this.cmsiEdit.Size = new System.Drawing.Size(110, 38);
            this.cmsiEdit.Text = "Edit";
            this.cmsiEdit.Click += new System.EventHandler(this.cmsiEdit_Click);
            // 
            // pbPeople
            // 
            this.pbPeople.Image = global::Presentation_Layer.Properties.Resources.DocumentSettings;
            this.pbPeople.Location = new System.Drawing.Point(203, 12);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(185, 185);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPeople.TabIndex = 8;
            this.pbPeople.TabStop = false;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblRecordCount.Location = new System.Drawing.Point(12, 581);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(155, 26);
            this.lblRecordCount.TabIndex = 17;
            this.lblRecordCount.Text = "# Records: -1";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(453, 575);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(599, 621);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.dgvApplicationTypes);
            this.Controls.Add(this.lblApplicationTypes);
            this.MaximumSize = new System.Drawing.Size(615, 660);
            this.MinimumSize = new System.Drawing.Size(615, 660);
            this.Name = "frmApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApplicationForms";
            this.Load += new System.EventHandler(this.frmApplicationForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            this.cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplicationTypes;
        private System.Windows.Forms.DataGridView dgvApplicationTypes;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem cmsiEdit;
        private System.Windows.Forms.Button btnClose;
    }
}