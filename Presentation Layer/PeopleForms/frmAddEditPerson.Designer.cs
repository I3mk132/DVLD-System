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
            this.lblAddNewPerson = new System.Windows.Forms.Label();
            this.ucEditPerson1 = new Presentation_Layer.UserControls.ucAddEditPerson();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.pbNationalNo = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNationalNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddNewPerson
            // 
            this.lblAddNewPerson.AutoSize = true;
            this.lblAddNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewPerson.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAddNewPerson.Location = new System.Drawing.Point(308, 24);
            this.lblAddNewPerson.Name = "lblAddNewPerson";
            this.lblAddNewPerson.Size = new System.Drawing.Size(263, 37);
            this.lblAddNewPerson.TabIndex = 3;
            this.lblAddNewPerson.Text = "Add new person";
            // 
            // ucEditPerson1
            // 
            this.ucEditPerson1.BackColor = System.Drawing.SystemColors.Control;
            this.ucEditPerson1.Location = new System.Drawing.Point(12, 96);
            this.ucEditPerson1.Name = "ucEditPerson1";
            this.ucEditPerson1.Size = new System.Drawing.Size(873, 351);
            this.ucEditPerson1.TabIndex = 4;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.DimGray;
            this.lblPersonID.Location = new System.Drawing.Point(12, 60);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(107, 24);
            this.lblPersonID.TabIndex = 9;
            this.lblPersonID.Text = "Person ID:";
            // 
            // pbNationalNo
            // 
            this.pbNationalNo.Image = global::Presentation_Layer.Properties.Resources.Tag;
            this.pbNationalNo.Location = new System.Drawing.Point(146, 60);
            this.pbNationalNo.Name = "pbNationalNo";
            this.pbNationalNo.Size = new System.Drawing.Size(25, 25);
            this.pbNationalNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNationalNo.TabIndex = 38;
            this.pbNationalNo.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.DimGray;
            this.lblID.Location = new System.Drawing.Point(177, 61);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(45, 24);
            this.lblID.TabIndex = 39;
            this.lblID.Text = "N/A";
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(901, 458);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pbNationalNo);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.ucEditPerson1);
            this.Controls.Add(this.lblAddNewPerson);
            this.Name = "frmAddEditPerson";
            this.Text = "Add / Edit person info";
            ((System.ComponentModel.ISupportInitialize)(this.pbNationalNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewPerson;
        private UserControls.ucAddEditPerson ucEditPerson1;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.PictureBox pbNationalNo;
        private System.Windows.Forms.Label lblID;
    }
}