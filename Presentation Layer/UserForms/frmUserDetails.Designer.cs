namespace Presentation_Layer.UserForms
{
    partial class frmUserDetails
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
            this.btnClose = new System.Windows.Forms.Button();
            this.ucPersonDetails1 = new Presentation_Layer.UserControls.ucPersonDetails();
            this.ucLoginInfo1 = new Presentation_Layer.UserControls.ucLoginInfo();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(748, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 147;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ucPersonDetails1
            // 
            this.ucPersonDetails1.BackColor = System.Drawing.SystemColors.Control;
            this.ucPersonDetails1.Location = new System.Drawing.Point(12, 12);
            this.ucPersonDetails1.Name = "ucPersonDetails1";
            this.ucPersonDetails1.PersonID = -1;
            this.ucPersonDetails1.Size = new System.Drawing.Size(870, 291);
            this.ucPersonDetails1.TabIndex = 148;
            // 
            // ucLoginInfo1
            // 
            this.ucLoginInfo1.BackColor = System.Drawing.SystemColors.Control;
            this.ucLoginInfo1.Location = new System.Drawing.Point(12, 309);
            this.ucLoginInfo1.Name = "ucLoginInfo1";
            this.ucLoginInfo1.Size = new System.Drawing.Size(870, 97);
            this.ucLoginInfo1.TabIndex = 149;
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(894, 461);
            this.Controls.Add(this.ucLoginInfo1);
            this.Controls.Add(this.ucPersonDetails1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmUserDetails";
            this.Text = "frmUserDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private UserControls.ucPersonDetails ucPersonDetails1;
        private UserControls.ucLoginInfo ucLoginInfo1;
    }
}