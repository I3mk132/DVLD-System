namespace Presentation_Layer.ApplicationForms.LocalDrivingLicenseApplicationsForms
{
    partial class frmScheduleTestAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.lblTestAppointments = new System.Windows.Forms.Label();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ucApplicaitonBasicInfo1 = new Presentation_Layer.UserControls.ApplicationsUserControl.ucApplicaitonBasicInfo();
            this.ucDLApplicationInfo1 = new Presentation_Layer.UserControls.ApplicationsUserControl.ucDLApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.pbIcon.Location = new System.Drawing.Point(304, 9);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(150, 150);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.cms;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 670);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(717, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.Location = new System.Drawing.Point(12, 640);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(150, 24);
            this.lblAppointments.TabIndex = 4;
            this.lblAppointments.Text = "Appointments: ";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblRecordCount.Location = new System.Drawing.Point(12, 833);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(155, 26);
            this.lblRecordCount.TabIndex = 17;
            this.lblRecordCount.Text = "# Records: -1";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(595, 829);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.White;
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = global::Presentation_Layer.Properties.Resources.DocumentAdd;
            this.pbAdd.Location = new System.Drawing.Point(644, 616);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(85, 48);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 19;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // lblTestAppointments
            // 
            this.lblTestAppointments.AutoSize = true;
            this.lblTestAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestAppointments.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTestAppointments.Location = new System.Drawing.Point(217, 176);
            this.lblTestAppointments.Name = "lblTestAppointments";
            this.lblTestAppointments.Size = new System.Drawing.Size(314, 31);
            this.lblTestAppointments.TabIndex = 20;
            this.lblTestAppointments.Text = "??? Test Appointments";
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiTakeTest});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(139, 80);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Image = global::Presentation_Layer.Properties.Resources.EditPerson32;
            this.tsmiEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(138, 38);
            this.tsmiEdit.Text = "Edit";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiTakeTest
            // 
            this.tsmiTakeTest.Image = global::Presentation_Layer.Properties.Resources.Test32;
            this.tsmiTakeTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTakeTest.Name = "tsmiTakeTest";
            this.tsmiTakeTest.Size = new System.Drawing.Size(138, 38);
            this.tsmiTakeTest.Text = "Take Test";
            this.tsmiTakeTest.Click += new System.EventHandler(this.tsmiTakeTest_Click);
            // 
            // ucApplicaitonBasicInfo1
            // 
            this.ucApplicaitonBasicInfo1.BackColor = System.Drawing.Color.White;
            this.ucApplicaitonBasicInfo1.Location = new System.Drawing.Point(12, 380);
            this.ucApplicaitonBasicInfo1.Name = "ucApplicaitonBasicInfo1";
            this.ucApplicaitonBasicInfo1.Padding = new System.Windows.Forms.Padding(4);
            this.ucApplicaitonBasicInfo1.Size = new System.Drawing.Size(717, 221);
            this.ucApplicaitonBasicInfo1.TabIndex = 2;
            // 
            // ucDLApplicationInfo1
            // 
            this.ucDLApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ucDLApplicationInfo1.Location = new System.Drawing.Point(12, 235);
            this.ucDLApplicationInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDLApplicationInfo1.Name = "ucDLApplicationInfo1";
            this.ucDLApplicationInfo1.Padding = new System.Windows.Forms.Padding(6);
            this.ucDLApplicationInfo1.Size = new System.Drawing.Size(717, 137);
            this.ucDLApplicationInfo1.TabIndex = 1;
            // 
            // frmScheduleTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(742, 881);
            this.Controls.Add(this.lblTestAppointments);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ucApplicaitonBasicInfo1);
            this.Controls.Add(this.ucDLApplicationInfo1);
            this.Controls.Add(this.pbIcon);
            this.Name = "frmScheduleTestAppointments";
            this.Text = "frmScheduleTest";
            this.Load += new System.EventHandler(this.frmScheduleTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIcon;
        private UserControls.ApplicationsUserControl.ucDLApplicationInfo ucDLApplicationInfo1;
        private UserControls.ApplicationsUserControl.ucApplicaitonBasicInfo ucApplicaitonBasicInfo1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label lblTestAppointments;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiTakeTest;
    }
}