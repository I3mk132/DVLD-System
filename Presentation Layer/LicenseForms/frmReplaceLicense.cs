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
    public partial class frmReplaceLicense : Form
    {
        public frmReplaceLicense()
        {
            InitializeComponent();
        }

        private void frmReplaceLicense_Load(object sender, EventArgs e)
        {
            rbDameged.Checked = true;
        }

        int LocalLicenseID = -1;
        DateTime ExpirationDate;
        private enum enReplacement { Dameged = 4, Lost = 3 };
        private enReplacement _mode;
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
            "Are you sure you want to Replace license? ",
            "Issue License", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            ) == DialogResult.Yes)
            {

                clsApplications app = new clsApplications();
                clsLicenses license = clsLicenses.Find(LocalLicenseID);

                app.PersonID = license.PersonID;
                app.ApplicationDate = DateTime.Now;
                app.ApplicationTypeID = (int)_mode;
                app.ApplicationStatus = "Completed";
                app.LastStatusDate = DateTime.Now;
                app.PaidFees = Convert.ToDecimal(lblApplicationFees.Text);
                app.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                if (app.Save())
                {
                    clsLicenses lic = new clsLicenses();

                    if (license.Deactivate())
                    {
                        lic.ApplicationID = app.ApplicationID;
                        lic.DriverID = license.DriverID;
                        lic.LicenseClassID = license.LicenseClassID;
                        lic.IssueDate = license.IssueDate;
                        lic.ExpirationDate = license.ExpirationDate;
                        lic.Notes = license.Notes;
                        lic.PaidFees = app.PaidFees + clsApplicationTypes.Find(1).Fees;
                        lic.IsActive = true;
                        lic.IssueReason = "Replacement For " + (_mode == enReplacement.Lost ? "Lost":"Dameged");
                        lic.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                        if (lic.Save())
                        {
                            MessageBox.Show(
                                "Licesne Issued Successfully with ID = " + lic.LicenseID.ToString(),
                                "License Issued",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );

                            lblRLApplicationID.Text = lic.ApplicationID.ToString();
                            lblNewLicenseID.Text = lic.LicenseID.ToString();

                            lblShowLicenseInfo.Enabled = true;
                            lblSave.Enabled = false;

                            LocalLicenseID = lic.LicenseID;
                        }
                    }

                }

            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
                return;

            int LicenseID = Convert.ToInt32(txtFilter.Text);
            clsLicenses license = clsLicenses.Find(LicenseID);
            if (license != null)
            {
                if (!license.IsActive.Value)
                {
                    MessageBox.Show(
                        "License is not active.",
                        "License Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                ucLicenseCard1.LicenseID = LicenseID;
                LocalLicenseID = LicenseID;
                ucLicenseCard1.LoadData();
                ExpirationDate = license.ExpirationDate.Value;

                lblApplicationDate.Text = DateTime.Now.ToString("d");
                lblApplicationFees.Text = clsApplicationTypes.Find((int)_mode).Fees.ToString();
                lblOldLicenseID.Text = license.LicenseID.ToString();
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
            clsLicenses license = clsLicenses.Find(LocalLicenseID);

            frmLicenseHistory frm = new frmLicenseHistory(license.PersonID);
            frm.ShowDialog();
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(LocalLicenseID);
            frm.ShowDialog();
        }

        private void rbReplace_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDameged.Checked)
            {
                _mode = enReplacement.Dameged;

                lblReplaceLicense.Text = "Replace Dameged Licenses";
                this.Text = "Replace Dameged Licenses";

            }
            else
            {
                _mode = enReplacement.Lost;

                lblReplaceLicense.Text = "Replace Dameged Licenses";
                this.Text = "Replace Dameged Licenses";

            }

            lblApplicationFees.Text = clsApplicationTypes.Find((int)_mode).Fees.ToString();
        }

        private void rbDameged_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDameged.Checked)
            {
                _mode = enReplacement.Dameged;

                lblReplaceLicense.Text = "Replace Dameged Licenses";
                this.Text = "Replace Dameged Licenses";

            }
            else
            {
                _mode = enReplacement.Lost;

                lblReplaceLicense.Text = "Replace Dameged Licenses";
                this.Text = "Replace Dameged Licenses";

            }

            lblApplicationFees.Text = clsApplicationTypes.Find((int)_mode).Fees.ToString();
        }
    }
}
