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
using Presentation_Layer.ApplicationForms.LocalDrivingLicenseApplicationsForms;
using Presentation_Layer.LicenseForms;
using Presentation_Layer.PeopleForms;

namespace Presentation_Layer.UserControls.ApplicationsUserControl
{
    public partial class ucIDLApplications : UserControl
    {
        public ucIDLApplications()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filterMode = cbFilterBy.Text;
            txtFilter.Text = "";


            if (filterMode == "I.License ID")
                txtFilter.KeyPress += txtFilter_KeyPress;
            else
                txtFilter.KeyPress -= txtFilter_KeyPress;

            if (filterMode == "None")
            {
                txtFilter.Visible = false;
            }
            else
            {
                txtFilter.Visible = true;
                txtFilter.Focus();

            }

        }

        DataTable dt = null;
        private void _UpdateData()
        {
            dgvApplicationsList.DataSource = dt;
            lblRecordCount.Text = "# Records: " + dt.Rows.Count.ToString();
        }
        public void RefreshDGV()
        {
            dt = clsInternationalLicenses.GetAll();
            _UpdateData();
        }

        private void _AddFilter()
        {

            string FilterMode = cbFilterBy.Text;
            string text = txtFilter.Text;

            if (text == "")
            {
                RefreshDGV();
                return;
            }
            switch (FilterMode)
            {
                case "None":
                    dt = clsInternationalLicenses.GetAll(); break;
                case "I.License ID":
                    dt = clsInternationalLicenses.GetAllFiltered(InternationalLicenseID: Convert.ToInt32(text)); break;
                case "National No.":
                    dt = clsInternationalLicenses.GetAllFiltered(NationalNo: text); break;
                case "Fullname":
                    dt = clsInternationalLicenses.GetAllFiltered(Fullname: text); break;
   
            }

            _UpdateData();

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _AddFilter();
        }

        private void ucIDLApplications_Load(object sender, EventArgs e)
        {
            RefreshDGV();
            cbFilterBy.SelectedIndex = 0;
        }

        private void cmsiShowPersonDetails_Click(object sender, EventArgs e)
        {
            if (dgvApplicationsList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int LicenseID = Convert.ToInt32(row.Cells[0].Value);

                clsInternationalLicenses license = clsInternationalLicenses.Find(LicenseID);

                frmPersonDetails frm = new frmPersonDetails(license.LocalLicense.PersonID);
                frm.ShowDialog();
                
                RefreshDGV();
            }
        }

        private void cmsiShowLicense_Click(object sender, EventArgs e)
        {
            if (dgvApplicationsList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int LicenseID = Convert.ToInt32(row.Cells[0].Value);

                frmInterLicenseInfo frm = new frmInterLicenseInfo(LicenseID);
                frm.ShowDialog();
                RefreshDGV();
            }
        }

        private void cmsiShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            if (dgvApplicationsList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int LicenseID = Convert.ToInt32(row.Cells[0].Value);
                clsInternationalLicenses license = clsInternationalLicenses.Find(LicenseID);

                frmLicenseHistory frm = new frmLicenseHistory(license.LocalLicense.PersonID);
                frm.ShowDialog();
                RefreshDGV();
            }
        }
    }
}
