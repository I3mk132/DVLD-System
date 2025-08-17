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
using Presentation_Layer.ApplicationForms;
using Presentation_Layer.ApplicationForms.LocalDrivingLicenseApplicationsForms;
using Presentation_Layer.DriverForms;
using Presentation_Layer.LicenseForms;
using Presentation_Layer.PeopleForms;
using Presentation_Layer.UserForms;

namespace Presentation_Layer
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void msiPeople_Click(object sender, EventArgs e)
        {
            frmPeople people = new frmPeople();
            people.ShowDialog();
        }


        public bool logoutFlag = false;
        private void msiSignout_Click(object sender, EventArgs e)
        {
            logoutFlag = true;
            this.Close();
        }

        private void msiInformation_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails(clsGlobal.CurrentUser.UserID, clsGlobal.CurrentUser.PersonID);
            frm.ShowDialog();
        }

        private void msiChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID, clsGlobal.CurrentUser.PersonID);
            frm.ShowDialog();
        }

        private void msiUsers_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.ShowDialog();
        }

        private void msiManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmApplicationTypes frm = new frmApplicationTypes();
            frm.ShowDialog();
        }

        private void msiManageTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void replacementForToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiLocalDrivingLicenses_Click(object sender, EventArgs e)
        {
            frmAddEditLDLApplication frm = new frmAddEditLDLApplication();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLDLApplications frm = new frmLDLApplications();
            frm.ShowDialog();
        }

        private void msiDrivers_Click(object sender, EventArgs e)
        {
            frmDrivers frm = new frmDrivers();
            frm.ShowDialog();
        }

        private void tsmiInternationalDrivingLicenses_Click(object sender, EventArgs e)
        {
            frmIssueInterLicense frm = new frmIssueInterLicense();
            frm.ShowDialog();
        }

        private void internationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInterLicenses frm = new frmInterLicenses();
            frm.ShowDialog();
        }

        private void tsmiRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewLicense frm = new frmRenewLicense(); 
            frm.ShowDialog();
        }
    }
}
