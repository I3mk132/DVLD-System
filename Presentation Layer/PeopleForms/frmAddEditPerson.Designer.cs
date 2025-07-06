namespace Presentation_Layer.PeopleForms
{
    partial class frmAddEditPerson
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
            this.lblPersonAddEdit = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.lblPersonIDValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbNationalNo = new System.Windows.Forms.PictureBox();
            this.ucAddEditPerson1 = new Presentation_Layer.UserControls.ucAddEditPerson();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNationalNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonAddEdit
            // 
            this.lblPersonAddEdit.AutoSize = true;
            this.lblPersonAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonAddEdit.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPersonAddEdit.Location = new System.Drawing.Point(350, 58);
            this.lblPersonAddEdit.Name = "lblPersonAddEdit";
            this.lblPersonAddEdit.Size = new System.Drawing.Size(272, 37);
            this.lblPersonAddEdit.TabIndex = 5;
            this.lblPersonAddEdit.Text = "Add New Person";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.BackColor = System.Drawing.SystemColors.Control;
            this.lbPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.ForeColor = System.Drawing.Color.Black;
            this.lbPersonID.Location = new System.Drawing.Point(8, 8);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(99, 20);
            this.lbPersonID.TabIndex = 48;
            this.lbPersonID.Text = "Person ID: ";
            // 
            // lblPersonIDValue
            // 
            this.lblPersonIDValue.AutoSize = true;
            this.lblPersonIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblPersonIDValue.Location = new System.Drawing.Point(143, 8);
            this.lblPersonIDValue.Name = "lblPersonIDValue";
            this.lblPersonIDValue.Size = new System.Drawing.Size(35, 20);
            this.lblPersonIDValue.TabIndex = 93;
            this.lblPersonIDValue.Text = "N/A";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pbNationalNo);
            this.panel1.Controls.Add(this.lbPersonID);
            this.panel1.Controls.Add(this.lblPersonIDValue);
            this.panel1.Location = new System.Drawing.Point(61, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 36);
            this.panel1.TabIndex = 94;
            // 
            // pbNationalNo
            // 
            this.pbNationalNo.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pbNationalNo.Location = new System.Drawing.Point(103, 6);
            this.pbNationalNo.Name = "pbNationalNo";
            this.pbNationalNo.Size = new System.Drawing.Size(25, 25);
            this.pbNationalNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNationalNo.TabIndex = 112;
            this.pbNationalNo.TabStop = false;
            // 
            // ucAddEditPerson1
            // 
            this.ucAddEditPerson1.BackColor = System.Drawing.SystemColors.Control;
            this.ucAddEditPerson1.Location = new System.Drawing.Point(61, 122);
            this.ucAddEditPerson1.Name = "ucAddEditPerson1";
            this.ucAddEditPerson1.Size = new System.Drawing.Size(860, 327);
            this.ucAddEditPerson1.TabIndex = 6;
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(972, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucAddEditPerson1);
            this.Controls.Add(this.lblPersonAddEdit);
            this.Name = "frmAddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit person";
            this.Load += new System.EventHandler(this.frmAddEditPerson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNationalNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonAddEdit;
        private UserControls.ucAddEditPerson ucAddEditPerson1;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.Label lblPersonIDValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbNationalNo;
    }
}