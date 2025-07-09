namespace Presentation_Layer.UserControls
{
    partial class ucUsersList
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.dgvPersonsList = new System.Windows.Forms.DataGridView();
            this.ucUserFilter1 = new Presentation_Layer.UserControls.ucUserFilter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblRecordCount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvPersonsList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucUserFilter1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 404);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblRecordCount.Location = new System.Drawing.Point(3, 371);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(155, 26);
            this.lblRecordCount.TabIndex = 16;
            this.lblRecordCount.Text = "# Records: -1";
            // 
            // dgvPersonsList
            // 
            this.dgvPersonsList.AllowUserToAddRows = false;
            this.dgvPersonsList.AllowUserToDeleteRows = false;
            this.dgvPersonsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPersonsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPersonsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonsList.Location = new System.Drawing.Point(3, 89);
            this.dgvPersonsList.MultiSelect = false;
            this.dgvPersonsList.Name = "dgvPersonsList";
            this.dgvPersonsList.ReadOnly = true;
            this.dgvPersonsList.Size = new System.Drawing.Size(864, 279);
            this.dgvPersonsList.TabIndex = 15;
            // 
            // ucUserFilter1
            // 
            this.ucUserFilter1.BackColor = System.Drawing.SystemColors.Control;
            this.ucUserFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserFilter1.Location = new System.Drawing.Point(3, 3);
            this.ucUserFilter1.Name = "ucUserFilter1";
            this.ucUserFilter1.Size = new System.Drawing.Size(864, 80);
            this.ucUserFilter1.TabIndex = 17;
            // 
            // ucUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucUsersList";
            this.Size = new System.Drawing.Size(870, 404);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.DataGridView dgvPersonsList;
        private ucUserFilter ucUserFilter1;
    }
}
