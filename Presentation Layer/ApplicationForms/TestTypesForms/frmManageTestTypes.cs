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

namespace Presentation_Layer.ApplicationForms
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshDgv();

            int totalWidth = dgvTestTypes.ClientSize.Width;

            dgvTestTypes.Columns[0].Width = (int)(totalWidth * 0.1);
            dgvTestTypes.Columns[1].Width = (int)(totalWidth * 0.3);
            dgvTestTypes.Columns[2].Width = (int)(totalWidth * 0.5);
            dgvTestTypes.Columns[3].Width = (int)(totalWidth * 0.1);

            lblRecordCount.Text = "# Records: " + dgvTestTypes.RowCount.ToString();
        }

        private void _RefreshDgv()
        {
            dgvTestTypes.DataSource = clsTestTypes.GetTestTypesList();
        }

        private void cmsiEdit_Click(object sender, EventArgs e)
        {
            if (dgvTestTypes.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvTestTypes.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int id = Convert.ToInt32(row.Cells[0].Value);
                frmEditTestType frm = new frmEditTestType(id);
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

