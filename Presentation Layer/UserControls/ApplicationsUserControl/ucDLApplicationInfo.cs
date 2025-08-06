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

namespace Presentation_Layer.UserControls.ApplicationsUserControl
{
    public partial class ucDLApplicationInfo : UserControl
    {
        public int AppID = -1;
        public ucDLApplicationInfo()
        {
            InitializeComponent();
        }

        private void ucDLApplicationInfo_Load(object sender, EventArgs e)
        {
            LoadDLApplicationData();
        }
        private void LoadDLApplicationData()
        {
            clsLocalDrivingLicenseApplications app = clsLocalDrivingLicenseApplications.Find(AppID);

            if (app != null)
            {
                lblDLAppIDValue.Text = app.LocalDrivingLicenseApplicationID.ToString();
                lblLicenseValue.Text = app.LicenseClassName;
                lblPassedTestValue.Text = app.PassedTestCount.ToString();
            }
            else
            {
                lblDLAppIDValue.Text = "???";
                lblLicenseValue.Text = "???";
                lblPassedTestValue.Text = "???";
            }
        }

        private void lblShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(AppID);
            frm.ShowDialog();   
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
