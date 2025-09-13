using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Presentation_Layer.ApplicationForms.LicensesForms;
using Presentation_Layer.ApplicationForms.LocalDrivingLicenseApplicationsForms;
using Presentation_Layer.LicenseForms;
using Presentation_Layer.UserForms;

namespace Presentation_Layer.UserControls.ApplicationsUserControl
{
    public partial class ucLDLApplications : UserControl
    {
        public ucLDLApplications()
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

        private bool rbStatusVisible
        {
            set
            {
                rbNone.Visible = value;
                rbCompleted.Visible = value;
                rbCancelled.Visible = value;
                rbNew.Visible = value;

            }
            get
            {
                return rbNone.Visible;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filterMode = cbFilterBy.Text;
            txtFilter.Text = "";
            rbNone.Checked = true;

            if (filterMode == "L.D.L.App ID")
                txtFilter.KeyPress += txtFilter_KeyPress;
            else
                txtFilter.KeyPress -= txtFilter_KeyPress;

            if (filterMode == "Status")
            {
                txtFilter.Visible = false;
                rbStatusVisible = true;
                rbNone.Focus();
            }
            else if (filterMode == "None")
            {
                txtFilter.Visible = false;
                rbStatusVisible = false;
            }
            else
            {
                txtFilter.Visible = true;
                rbStatusVisible = false;
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
            dt = clsLocalDrivingLicenseApplications.GetAll();
            _UpdateData();
        }

        private void _AddFilter()
        {

            string FilterMode = cbFilterBy.Text;
            string text = txtFilter.Text;

            if (text == "" && FilterMode != "Status")
            {
                dt = clsLocalDrivingLicenseApplications.GetAll();
                _UpdateData();
                return;
            }
            switch (FilterMode)
            {
                case "None":
                    dt = clsLocalDrivingLicenseApplications.GetAll(); break;
                case "L.D.L.App ID":
                    dt = clsLocalDrivingLicenseApplications.GetAllFiltered(LocalDrivingLicenseApplicationID: Convert.ToInt32(text)); break;
                case "National No.":
                    dt = clsLocalDrivingLicenseApplications.GetAllFiltered(NationalNo: text); break;
                case "Fullname":
                    dt = clsLocalDrivingLicenseApplications.GetAllFiltered(Fullname: text); break;
                case "Status":
                    dt = clsLocalDrivingLicenseApplications.GetAllFiltered(Status: _CheckedStatus); break;
            }

            _UpdateData();

        }

        private string _CheckedStatus = "";
        private void rbStatus_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton status = (RadioButton)sender;

            if (!status.Checked)
                return;
            if (status.Tag.ToString() == "None")
                _CheckedStatus = "";
            else
                _CheckedStatus = status.Tag.ToString();

            _AddFilter();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _AddFilter();
        }

        private void cmsiShowApplicationDetails_Click(object sender, EventArgs e)
        {
            if (dgvApplicationsList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int LDLApplicationID = Convert.ToInt32(row.Cells[0].Value);

                frmApplicationInfo frm = new frmApplicationInfo(LDLApplicationID);
                frm.ShowDialog();

                RefreshDGV();
            }
        }

        private void cmsiEdit_Click(object sender, EventArgs e)
        {
            if (dgvApplicationsList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int LDLApplicationID = Convert.ToInt32(row.Cells[0].Value);

                frmAddEditLDLApplication frm = new frmAddEditLDLApplication(LDLApplicationID);
                frm.ShowDialog();
                RefreshDGV();
            }
        }

        private void cmsiDelete_Click(object sender, EventArgs e)
        {
            if (dgvApplicationsList.SelectedCells.Count > 0)
            {
                if (MessageBox.Show(
                    "Are you sure you want to delete Application ? ",
                    "Person delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
                    DataGridViewRow row = selectedCell.OwningRow;

                    int LDLApplicationID = Convert.ToInt32(row.Cells[0].Value);

                    if (clsLocalDrivingLicenseApplications.Delete(LDLApplicationID))
                        MessageBox.Show("Application Deleted Successfully");
                    else
                        MessageBox.Show("Application Couldnt be deleted because there are some data linked to it");

                    RefreshDGV();
                }
            }
        }

        private void cmsiCancelApplication_Click(object sender, EventArgs e)
        {
            if (dgvApplicationsList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int LDLApplicationID = Convert.ToInt32(row.Cells[0].Value);

                clsLocalDrivingLicenseApplications app = clsLocalDrivingLicenseApplications.Find(LDLApplicationID);
                if (app.CancelApplication())
                {
                    MessageBox.Show("Application Cancelled Successfully. ");
                }
                else
                {
                    MessageBox.Show("Something went wrong while trying to Change status to Cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RefreshDGV();
            }
        }

        private void cmsiShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            if (dgvApplicationsList.SelectedCells.Count > 0)
            {


                DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int LDLApplicationID = Convert.ToInt32(row.Cells[0].Value);
                
                frmLicenseHistory frm = new frmLicenseHistory(clsLocalDrivingLicenseApplications.Find(LDLApplicationID).PersonID);
                frm.ShowDialog();
                

                RefreshDGV();
            }
        }

        private void ucLDLApplications_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void cmsiSechduleTests_Click(object sender, EventArgs e)
        {
            
        }

        private void cms_Opening(object sender, CancelEventArgs e)
        {
            if (dgvApplicationsList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int PassedTests = Convert.ToInt32(row.Cells[5].Value);
                string Status = row.Cells[6].Value.ToString();

                tsmiVision.Enabled = false;
                tsmiWritten.Enabled = false;
                tsmiStreet.Enabled = false;

                cmsiEdit.Enabled = false;
                cmsiDelete.Enabled = false;
                cmsiCancelApplication.Enabled = false;
                cmsiIssueDrivingLicense.Enabled = false;
                cmsiSechduleTests.Enabled = false;
                cmsiShowLicense.Enabled = false;


                if (Status == "New")
                {
                    switch (PassedTests)
                    {
                        case 0:
                            cmsiEdit.Enabled = true;
                            cmsiDelete.Enabled = true;
                            cmsiCancelApplication.Enabled = true;
                            cmsiSechduleTests.Enabled = true;

                            tsmiVision.Enabled = true;
                            break;

                        case 1:
                            cmsiDelete.Enabled = true;
                            cmsiCancelApplication.Enabled = true;
                            cmsiSechduleTests.Enabled = true;

                            tsmiWritten.Enabled= true;
                            break;

                        case 2:
                            cmsiDelete.Enabled = true;
                            cmsiCancelApplication.Enabled = true;
                            cmsiSechduleTests.Enabled = true;

                            tsmiStreet.Enabled = true;
                            break;

                        case 3:
                            cmsiDelete.Enabled = true;
                            cmsiCancelApplication.Enabled = true;
                            cmsiIssueDrivingLicense.Enabled=true;
                            break;
                    }
                    
                }
                else if (Status == "Completed")
                {
                    cmsiShowLicense.Enabled = true;
                }

            }
        }


        private void SechduleTest_Click(object sender, EventArgs e)
        {
            if (dgvApplicationsList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int LDLApplicationID = Convert.ToInt32(row.Cells[0].Value);
                int TestTypeID = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
                frmScheduleTestAppointments frm = new frmScheduleTestAppointments(LDLApplicationID, TestTypeID);
                frm.ShowDialog();

                RefreshDGV();
            }
        }

        private void cmsiIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            if (dgvApplicationsList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvApplicationsList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int LDLApplicationID = Convert.ToInt32(row.Cells[0].Value);


                frmIssueLicenseFirstTime frm = new frmIssueLicenseFirstTime(LDLApplicationID, clsLocalDrivingLicenseApplications.Find(LDLApplicationID).ApplicationID);
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

                int LDLApplicationID = Convert.ToInt32(row.Cells[0].Value);

                clsLicenses license = clsLicenses.FindByAppID(clsLocalDrivingLicenseApplications.Find(LDLApplicationID).ApplicationID);

                frmLicenseInfo frm = new frmLicenseInfo(license.LicenseID);
                frm.ShowDialog();

                RefreshDGV();
            }
        }

        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }

        private void lblFilter_Click(object sender, EventArgs e)
        {

        }

        private void lblRecordCount_Click(object sender, EventArgs e)
        {

        }

        private void dgvApplicationsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmss2_Click(object sender, EventArgs e)
        {

        }

        private void cmss1_Click(object sender, EventArgs e)
        {

        }

        private void cmss3_Click(object sender, EventArgs e)
        {

        }
    }
}
