namespace Presentation_Layer.LicenseForms
{
    partial class frmIssueLicenseFirstTime
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
            this.ucDLApplicationInfo1 = new Presentation_Layer.UserControls.ApplicationsUserControl.ucDLApplicationInfo();
            this.ucApplicaitonBasicInfo1 = new Presentation_Layer.UserControls.ApplicationsUserControl.ucApplicaitonBasicInfo();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // ucDLApplicationInfo1
            // 
            this.ucDLApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ucDLApplicationInfo1.Location = new System.Drawing.Point(12, 12);
            this.ucDLApplicationInfo1.Name = "ucDLApplicationInfo1";
            this.ucDLApplicationInfo1.Padding = new System.Windows.Forms.Padding(4);
            this.ucDLApplicationInfo1.Size = new System.Drawing.Size(678, 126);
            this.ucDLApplicationInfo1.TabIndex = 0;
            // 
            // ucApplicaitonBasicInfo1
            // 
            this.ucApplicaitonBasicInfo1.BackColor = System.Drawing.Color.White;
            this.ucApplicaitonBasicInfo1.Location = new System.Drawing.Point(12, 144);
            this.ucApplicaitonBasicInfo1.Name = "ucApplicaitonBasicInfo1";
            this.ucApplicaitonBasicInfo1.Padding = new System.Windows.Forms.Padding(4);
            this.ucApplicaitonBasicInfo1.Size = new System.Drawing.Size(678, 221);
            this.ucApplicaitonBasicInfo1.TabIndex = 1;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(115, 371);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(575, 137);
            this.txtNote.TabIndex = 136;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Black;
            this.lblNote.Location = new System.Drawing.Point(21, 374);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(57, 20);
            this.lblNote.TabIndex = 135;
            this.lblNote.Text = "Note: ";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Presentation_Layer.Properties.Resources.Title32;
            this.pictureBox8.Location = new System.Drawing.Point(84, 374);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 134;
            this.pictureBox8.TabStop = false;
            // 
            // lblSave
            // 
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.Image = global::Presentation_Layer.Properties.Resources.Save32;
            this.lblSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSave.Location = new System.Drawing.Point(496, 514);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(196, 40);
            this.lblSave.TabIndex = 144;
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
            this.btnClose.Location = new System.Drawing.Point(356, 514);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 143;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmIssueLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(704, 566);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.ucApplicaitonBasicInfo1);
            this.Controls.Add(this.ucDLApplicationInfo1);
            this.Name = "frmIssueLicenseFirstTime";
            this.Text = "frmIssueLicenseFirstTime";
            this.Load += new System.EventHandler(this.frmIssueLicenseFirstTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ApplicationsUserControl.ucDLApplicationInfo ucDLApplicationInfo1;
        private UserControls.ApplicationsUserControl.ucApplicaitonBasicInfo ucApplicaitonBasicInfo1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button lblSave;
        private System.Windows.Forms.Button btnClose;
    }
}