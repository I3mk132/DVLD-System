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
using Presentation_Layer.ApplicationForms.LicensesForms;

namespace Presentation_Layer.LicenseForms
{
    public partial class frmLicenseHistory : Form
    {
        private int _PersonID = -1;
        public frmLicenseHistory(int personID)
        {
            InitializeComponent();
            _PersonID = personID;

        }



        DataTable LocalDt = null, InternationalDt = null;
        private void _UpdateData()
        {
            dgvLocalLicenses.DataSource = LocalDt;
            lblRecordCountLocal.Text = "# Records: " + LocalDt.Rows.Count.ToString();

            dgvInternationalLicenses.DataSource = InternationalDt;
            lblRecordCountInter.Text = "# Records: " + InternationalDt.Rows.Count.ToString();
        }
        public void RefreshDGV()
        {
            LocalDt = clsLicenses.GetAllFor(_PersonID);
            InternationalDt = clsInternationalLicenses.GetAllFor(_PersonID);
            _UpdateData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmsiShowLicense_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (dgvLocalLicenses.SelectedCells.Count > 0)
                {
                    DataGridViewCell selectedCell = dgvLocalLicenses.SelectedCells[0];
                    DataGridViewRow row = selectedCell.OwningRow;

                    int LicenseID = Convert.ToInt32(row.Cells[0].Value);
                    frmLicenseInfo frm = new frmLicenseInfo(LicenseID);
                    frm.ShowDialog();
                    RefreshDGV();
                }
            }
            else
            {
                if (dgvInternationalLicenses.SelectedCells.Count > 0)
                {
                    DataGridViewCell selectedCell = dgvInternationalLicenses.SelectedCells[0];
                    DataGridViewRow row = selectedCell.OwningRow;

                    int LicenseID = Convert.ToInt32(row.Cells[0].Value);

                    frmInterLicenseInfo frm = new frmInterLicenseInfo(LicenseID);
                    frm.ShowDialog();
                    RefreshDGV();
                }
            }
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            ucPersonSearch1.LoadPersonDetails(_PersonID);
            ucPersonSearch1.ActivateForm = false;
            RefreshDGV();
        }


    }
}
