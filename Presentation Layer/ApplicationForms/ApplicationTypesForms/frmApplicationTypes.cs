using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Presentation_Layer.PeopleForms;

namespace Presentation_Layer.ApplicationForms
{
    public partial class frmApplicationTypes : Form
    {
        public frmApplicationTypes()
        {
            InitializeComponent();
        }


        private void _RefreshDgv()
        {
            dgvApplicationTypes.DataSource = clsApplicationTypes.GetApplicationTypesList();
        }
        private void frmApplicationForms_Load(object sender, EventArgs e)
        {
            _RefreshDgv();

            int totalWidth = dgvApplicationTypes.ClientSize.Width;

            dgvApplicationTypes.Columns[0].Width = (int)(totalWidth * 0.2);
            dgvApplicationTypes.Columns[1].Width = (int)(totalWidth * 0.6);
            dgvApplicationTypes.Columns[2].Width = (int)(totalWidth * 0.2);

            lblRecordCount.Text = "# Records: " + dgvApplicationTypes.RowCount.ToString();
        }

        private void cmsiEdit_Click(object sender, EventArgs e)
        {
            if (dgvApplicationTypes.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvApplicationTypes.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int id = Convert.ToInt32(row.Cells[0].Value);
                frmEditApplication frm = new frmEditApplication(id);
                frm.ShowDialog();
            }
            _RefreshDgv();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
