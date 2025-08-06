namespace Presentation_Layer.ApplicationForms.LocalDrivingLicenseApplicationsForms
{
    partial class frmApplicationInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucDLApplicationInfo1
            // 
            this.ucDLApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ucDLApplicationInfo1.Location = new System.Drawing.Point(12, 12);
            this.ucDLApplicationInfo1.Name = "ucDLApplicationInfo1";
            this.ucDLApplicationInfo1.Padding = new System.Windows.Forms.Padding(4);
            this.ucDLApplicationInfo1.Size = new System.Drawing.Size(659, 126);
            this.ucDLApplicationInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Presentation_Layer.Properties.Resources.Close32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(537, 144);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 40);
            this.btnClose.TabIndex = 140;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(681, 193);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucDLApplicationInfo1);
            this.Name = "frmApplicationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApplicationInfo";
            this.Load += new System.EventHandler(this.frmApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ApplicationsUserControl.ucDLApplicationInfo ucDLApplicationInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}