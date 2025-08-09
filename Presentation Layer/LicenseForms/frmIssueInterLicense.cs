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

namespace Presentation_Layer.LicenseForms
{
    public partial class frmIssueInterLicense : Form
    {
        public frmIssueInterLicense()
        {
            InitializeComponent();
        }
        int LocalLicenseID = -1;
        DateTime ExpirationDate;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to issue an international license? ",
                "Issue License", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                if (DateTime.Now.AddYears(1) <= ExpirationDate)
                {
                    clsApplications app = new clsApplications();
                    clsLicenses license = clsLicenses.Find(LocalLicenseID);

                    app.PersonID = license.PersonID;
                    app.ApplicationDate = DateTime.Now;
                    app.ApplicationTypeID = 6;
                    app.ApplicationStatus = "Completed";
                    app.LastStatusDate = DateTime.Now;
                    app.PaidFees = Convert.ToDecimal(lblFees.Text);
                    app.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                    if (app.Save())
                    {
                        clsInternationalLicenses lic = new clsInternationalLicenses();

                        lic.ApplicationID = app.ApplicationID;
                        lic.DriverID = license.DriverID;
                        lic.IssuedUsingLocalLicenseID = license.LicenseID;
                        lic.IssueDate = DateTime.Now;
                        lic.ExpirationDate = DateTime.Now.AddYears(1);
                        lic.IsActive = true;
                        lic.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                        if (lic.Save())
                        {
                            MessageBox.Show(
                                "International Licesne Issued Successfully with ID = " + lic.InternationalLicenseID.ToString(),
                                "License Issued",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );

                            lblILApplicationID.Text = lic.ApplicationID.ToString();
                            lblILLicenseID.Text = lic.InternationalLicenseID.ToString();

                            lblShowLicenseInfo.Enabled = true;
                            lblSave.Enabled = false;
                        }
                    }

                }
                else
                {
                    MessageBox.Show(
                        "The license expired or will be expired soon you can't create an international license",
                        "Issue Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
                return;

            int LicenseID = Convert.ToInt32(txtFilter.Text);
            clsLicenses license = clsLicenses.Find(LicenseID);
            if (license != null)
            {
                ucLicenseCard1.LicenseID = LicenseID;
                LocalLicenseID = LicenseID;
                ucLicenseCard1.LoadData();
                ExpirationDate = license.ExpirationDate.Value;

                lblApplicationDate.Text = DateTime.Now.ToString("d");
                lblIssueDate.Text = DateTime.Now.ToString("d");
                lblFees.Text = clsApplicationTypes.Find(6).Fees.ToString();
                lblLocalLicenseID.Text = LicenseID.ToString();
                lblExpirationDate.Text = DateTime.Now.AddYears(1).ToString("d");
                lblCreatedBy.Text = clsGlobal.CurrentUser.Username;

                lblShowLicenseHistory.Enabled = true;
                lblSave.Enabled = true;


            }
            else
            {
                MessageBox.Show("License not found. ");
            }
        }

        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(clsLicenses.Find(LocalLicenseID).PersonID);
            frm.ShowDialog();
        }
    }
}
