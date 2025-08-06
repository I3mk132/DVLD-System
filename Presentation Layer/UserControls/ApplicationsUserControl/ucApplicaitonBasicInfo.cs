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
using Presentation_Layer.PeopleForms;

namespace Presentation_Layer.UserControls.ApplicationsUserControl
{
    public partial class ucApplicaitonBasicInfo : UserControl
    {
        public int AppID = -1;
        public ucApplicaitonBasicInfo()
        {
            InitializeComponent();
        }

        private void ucApplicaitonBasicInfo_Load(object sender, EventArgs e)
        {
            LoadAppData();
        }

        private void LoadAppData()
        {
            clsApplications app = clsApplications.Find(AppID);

            if (app != null)
            {
                lblIDValue.Text = app.ApplicationID.ToString();
                lblStatusValue.Text = app.ApplicationStatus.ToString();
                lblFeesValue.Text = app.PaidFees.ToString();
                lblTypeValue.Text = app.ApplicationTypeName;
                lblApplicantValue.Text = app.Fullname;
                lblDateValue.Text = app.ApplicationDate.Value.ToString("d");
                lblStatusDateValue.Text = app.LastStatusDate.Value.ToString("d");
                lblCreatedByValue.Text = app.CreatedByUsername;
            }

        }

        private void lblViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(clsApplications.Find(AppID).PersonID);
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
