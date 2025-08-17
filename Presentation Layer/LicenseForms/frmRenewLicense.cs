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
    public partial class frmRenewLicense : Form
    {
        public frmRenewLicense()
        {
            InitializeComponent();
        }
        int LocalLicenseID = -1;
        DateTime ExpirationDate;

        private void frmRenewLicense_Load(object sender, EventArgs e)
        {
            
        }

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
            "Are you sure you want to Renew license? ",
            "Issue License", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            ) == DialogResult.Yes)
            {

                clsApplications app = new clsApplications();
                clsLicenses license = clsLicenses.Find(LocalLicenseID);

                app.PersonID = license.PersonID;
                app.ApplicationDate = DateTime.Now;
                app.ApplicationTypeID = 2;
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
                        lic.IssueDate = DateTime.Now;
                        lic.ExpirationDate = DateTime.Now.AddYears(10); 
                        lic.Notes = txtNotes.Text;
                        lic.PaidFees = app.PaidFees; 
                        lic.IsActive = true;
                        lic.IssueReason = "Renew";
                        lic.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                        if (lic.Save())
                        {
                            MessageBox.Show(
                                " Licesne Issued Successfully with ID = " + lic.LicenseID.ToString(),
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
            else
            {
                MessageBox.Show(
                    "The license expired or will be expired soon you can't create an international license",
                    "Issue Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (DateTime.Now < license.ExpirationDate.Value)
                {
                    MessageBox.Show(
                        "license isnt expired yet. ",
                        "License Expiration", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error );
                    return;
                }
                ucLicenseCard1.LicenseID = LicenseID;
                LocalLicenseID = LicenseID;
                ucLicenseCard1.LoadData();
                ExpirationDate = license.ExpirationDate.Value;

                lblApplicationDate.Text = DateTime.Now.ToString("d");
                lblIssueDate.Text = DateTime.Now.ToString("d");
                lblApplicationFees.Text = clsApplicationTypes.Find(2).Fees.ToString();
                lblLicenseFees.Text = clsApplicationTypes.Find(1).Fees.ToString();
                lblOldLicenseID.Text = license.LicenseID.ToString();
                lblExpirationDate.Text = DateTime.Now.AddYears(10).ToString("d");
                lblTotalFees.Text = 
                    (Convert.ToDecimal(
                        lblLicenseFees.Text) + 
                    Convert.ToDecimal(
                        lblApplicationFees.Text)
                    ).ToString();
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
    }
}
