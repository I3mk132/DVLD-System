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
using Presentation_Layer.Properties;
using static Presentation_Layer.ApplicationForms.LocalDrivingLicenseApplicationsForms.frmScheduleTest;

namespace Presentation_Layer.ApplicationForms.LocalDrivingLicenseApplicationsForms
{
    public partial class frmTakeTest : Form
    {
        private int _LDLAppID = -1;
        private int _appID = -1;
        public enum enTestType { Vision = 1, Written = 2, Street = 3 }
        private enTestType _testType;

        public frmTakeTest(enTestType type, int LDLAppID = -1, int AppointemntID = -1)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
            _appID = AppointemntID;
            _testType = type;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void frmTakeTest_Load(object sender, EventArgs e)
        {

            switch (_testType)
            {
                case enTestType.Vision:
                    gbTest.Text = "Vision Test";
                    pbIcon.Image = Resources.eye;
                    this.Text = "Schedule Vision Test";
                    break;

                case enTestType.Street:
                    gbTest.Text = "Street Test";
                    pbIcon.Image = Resources.Driver;
                    this.Text = "Schedule Street Test";
                    break;

                case enTestType.Written:
                    gbTest.Text = "Written Test";
                    pbIcon.Image = Resources.Test;
                    this.Text = "Schedule Written Test";
                    break;
            }

            clsLocalDrivingLicenseApplications app = clsLocalDrivingLicenseApplications.Find(_LDLAppID);
            lblIDValue.Text = app.LocalDrivingLicenseApplicationID.ToString();
            lblClassValue.Text = app.LicenseClassName.ToString();
            lblNameValue.Text = app.Fullname.ToString();
            lblTrialValue.Text = (clsTests.GetTrialsCount(_LDLAppID, (int)_testType) + 1).ToString();
            lblDateValue.Text = DateTime.Now.ToString("d");
            rbFail.Checked = true;

            clsTestAppointments app1 = clsTestAppointments.Find(_appID);
            lblFeesValue.Text = app1.PaidFees.ToString() + "$";


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            clsTests test = new clsTests();

            test.TestAppointmentID = _appID;
            test.TestResult = rbPass.Checked;
            test.Notes = txtNote.Text;
            test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (test.Save())
            {
                MessageBox.Show("Test Taken Successfully. ");
                
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong while teking test. ");
            }
        }
    }
}
