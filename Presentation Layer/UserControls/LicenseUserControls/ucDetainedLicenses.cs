using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Presentation_Layer.ApplicationForms.LicensesForms;
using Presentation_Layer.ApplicationForms.LocalDrivingLicenseApplicationsForms;
using Presentation_Layer.LicenseForms;
using Presentation_Layer.LicenseForms.DetainLicenseForms;
using Presentation_Layer.PeopleForms;

namespace Presentation_Layer.UserControls.LicenseUserControls
{
    public partial class ucDetainedLicenses : UserControl
    {
        public ucDetainedLicenses()
        {
            InitializeComponent();
            cbFilterBy.SelectedIndex = 0;
            RefreshDGV();
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
            chkIsReleased.Checked = false;


            if (filterMode == "Detain ID" || filterMode == "Release Application ID")
                txtFilter.KeyPress += txtFilter_KeyPress;
            else
                txtFilter.KeyPress -= txtFilter_KeyPress;

            if (filterMode == "Is Released")
            {
                txtFilter.Visible = false;
                chkIsReleased.Visible = true;
                chkIsReleased.Focus();
            }
            else if (filterMode == "None")
            {
                txtFilter.Visible = false;
                chkIsReleased.Visible = false;
            }
            else
            {
                txtFilter.Visible = true;
                chkIsReleased.Visible = false;
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
            dt = clsDetainedLicenses.GetAll();
            _UpdateData();
        }

        private void _AddFilter()
        {

            string FilterMode = cbFilterBy.Text;
            string text = txtFilter.Text;

            if (text == "" && FilterMode != "Is Released")
            {
                RefreshDGV();
                return;
            }
            switch (FilterMode)
            {
                case "None":
                    dt = clsDetainedLicenses.GetAll(); break;
                case "Detain ID":
                    dt = clsDetainedLicenses.GetAllFiltered(DetainID: Convert.ToInt32(text)); break;
                case "Is Released":
                    dt = clsDetainedLicenses.GetAllFiltered(IsReleased:chkIsReleased.Checked); break;
                case "National No.":
                    dt = clsDetainedLicenses.GetAllFiltered(NationalNo: text); break;
                case "Full Name":
                    dt = clsDetainedLicenses.GetAllFiltered(Fullname: text); break;
                case "Release Application ID":
                    dt = clsDetainedLicenses.GetAllFiltered(ReleaseApplicationID: Convert.ToInt32(text)); break;
            }

            _UpdateData();

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _AddFilter();
        }

        private void chkIsReleased_CheckedChanged(object sender, EventArgs e)
        {
            _AddFilter();
        }

        private void tsmiShowPersonsLicenseHistory_Click(object sender, EventArgs e)
        {
            DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
            DataGridViewRow row = selectedCell.OwningRow;

            int LicenseID = Convert.ToInt32(row.Cells[1].Value);
            clsLicenses lic = clsLicenses.Find(LicenseID);

            frmLicenseHistory frm = new frmLicenseHistory(lic.PersonID);
            frm.ShowDialog();

            RefreshDGV();
        }

        private void tsmiShowPersonDetails_Click(object sender, EventArgs e)
        {
            DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
            DataGridViewRow row = selectedCell.OwningRow;

            int LicenseID = Convert.ToInt32(row.Cells[1].Value);
            clsLicenses lic = clsLicenses.Find(LicenseID);

            frmPersonDetails frm = new frmPersonDetails(lic.PersonID);
            frm.ShowDialog();

            RefreshDGV();
        }

        private void tsmiShowLicenseDetails_Click(object sender, EventArgs e)
        {
            DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
            DataGridViewRow row = selectedCell.OwningRow;

            int LicenseID = Convert.ToInt32(row.Cells[1].Value);

            frmLicenseInfo frm = new frmLicenseInfo(LicenseID);
            frm.ShowDialog();

            RefreshDGV();
        }

        private void tsmiReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
            DataGridViewRow row = selectedCell.OwningRow;

            int LicenseID = Convert.ToInt32(row.Cells[1].Value);

            frmReleaseLicense frm = new frmReleaseLicense(LicenseID);
            frm.ShowDialog();

            RefreshDGV();
        }

        private void cms_Opening(object sender, CancelEventArgs e)
        {
            DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
            DataGridViewRow row = selectedCell.OwningRow;

            bool IsReleased = Convert.ToBoolean(row.Cells[3].Value);

            
            tsmiReleaseDetainedLicense.Enabled = !IsReleased;
            
        }
    }
}
