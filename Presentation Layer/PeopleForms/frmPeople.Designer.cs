namespace Presentation_Layer.PeopleForms
{
    partial class frmPeople
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
            this.lblManagePeople = new System.Windows.Forms.Label();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.ucPersonsList2 = new Presentation_Layer.UserControls.ucPersonsList();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManagePeople
            // 
            this.lblManagePeople.AutoSize = true;
            this.lblManagePeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePeople.ForeColor = System.Drawing.Color.Firebrick;
            this.lblManagePeople.Location = new System.Drawing.Point(366, 178);
            this.lblManagePeople.Name = "lblManagePeople";
            this.lblManagePeople.Size = new System.Drawing.Size(215, 31);
            this.lblManagePeople.TabIndex = 2;
            this.lblManagePeople.Text = "Manage People";
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.SystemColors.Control;
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = global::Presentation_Layer.Properties.Resources.AddPerson;
            this.pbAdd.Location = new System.Drawing.Point(819, 208);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(85, 47);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 6;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(770, 520);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbPeople
            // 
            this.pbPeople.Image = global::Presentation_Layer.Properties.Resources.People;
            this.pbPeople.Location = new System.Drawing.Point(389, 12);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(160, 160);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPeople.TabIndex = 1;
            this.pbPeople.TabStop = false;
            // 
            // ucPersonsList2
            // 
            this.ucPersonsList2.BackColor = System.Drawing.Color.Transparent;
            this.ucPersonsList2.Location = new System.Drawing.Point(16, 222);
            this.ucPersonsList2.Name = "ucPersonsList2";
            this.ucPersonsList2.Size = new System.Drawing.Size(889, 323);
            this.ucPersonsList2.TabIndex = 9;
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(917, 565);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.ucPersonsList2);
            this.Controls.Add(this.lblManagePeople);
            this.Controls.Add(this.pbPeople);
            this.Name = "frmPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.frmPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.Label lblManagePeople;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Button btnClose;
        private UserControls.ucPersonsList ucPersonsList2;
    }
}