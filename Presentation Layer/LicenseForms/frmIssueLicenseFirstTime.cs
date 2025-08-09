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
    public partial class frmIssueLicenseFirstTime : Form
    {
        private int AppID, LDLAppID;
            
        public frmIssueLicenseFirstTime(int LDLAppID, int AppID)
        {
            InitializeComponent();
            ucApplicaitonBasicInfo1.AppID = AppID;
            ucDLApplicationInfo1.AppID = LDLAppID;
            this.AppID = AppID;
            this.LDLAppID = LDLAppID;

        }

        private void frmIssueLicenseFirstTime_Load(object sender, EventArgs e)
        {
            // Issue License // Add Driver // License history

        }

        private void lblSave_Click(object sender, EventArgs e)
        {

            clsDrivers driver = new clsDrivers();

            driver.PersonID = clsApplications.Find(AppID).PersonID;
            driver.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            driver.CreatedDate = DateTime.Now;
            
            if (MessageBox.Show(
                "Are you sure you want to save driver and license? ",
                "Add Driver and License",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (driver.Save())
                {
                    MessageBox.Show($"Driver Added Successfully. ID = {driver.DriverID}");

                    clsLocalDrivingLicenseApplications app = clsLocalDrivingLicenseApplications.Find(LDLAppID);
                    clsLicenses license = new clsLicenses();

                    license.ApplicationID = AppID;
                    license.DriverID = driver.DriverID;
                    license.LicenseClassID = app.LicenseClassID;
                    license.IssueDate = DateTime.Now;
                    license.ExpirationDate = DateTime.Now.AddYears(5);
                    license.Notes = txtNote.Text;
                    license.PaidFees = app.PaidFees;
                    license.IsActive = true;
                    license.IssueReason = "First Time";
                    license.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                    if (license.Save())
                    {
                        MessageBox.Show(
                            $"License Issued successfully. ID = {license.LicenseID}",
                            "Success.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        app.LastStatusDate = DateTime.Now;
                        app.ApplicationStatus = "Completed";

                        if (!app.Save())
                        {
                            MessageBox.Show("Something went wrong when trying to change status to complete");
                        }

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Something went wrong while Issuing License",
                            "Fail",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong while adding driver");
                    return;
                }
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
