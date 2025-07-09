namespace Presentation_Layer.UserControls
{
    partial class ucUserFilter
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
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.SystemColors.Control;
            this.cbFilterBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilterBy.DropDownHeight = 220;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.IntegralHeight = false;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
            this.cbFilterBy.Location = new System.Drawing.Point(132, 19);
            this.cbFilterBy.MaxDropDownItems = 11;
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(135, 28);
            this.cbFilterBy.TabIndex = 15;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.DimGray;
            this.lblFilter.Location = new System.Drawing.Point(11, 16);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(115, 26);
            this.lblFilter.TabIndex = 14;
            this.lblFilter.Text = "Filter By: ";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(295, 21);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(227, 26);
            this.txtFilter.TabIndex = 16;
            this.txtFilter.Visible = false;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.chkIsActive);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Controls.Add(this.lblFilter);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilter.Location = new System.Drawing.Point(5, 5);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(860, 71);
            this.gbFilter.TabIndex = 17;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // chkIsActive
            // 
            this.chkIsActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkIsActive.Location = new System.Drawing.Point(544, 27);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(84, 24);
            this.chkIsActive.TabIndex = 17;
            this.chkIsActive.Text = "IsActive";
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.Visible = false;
            // 
            // ucUserFilter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gbFilter);
            this.Name = "ucUserFilter";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(870, 81);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.CheckBox chkIsActive;
    }
}
