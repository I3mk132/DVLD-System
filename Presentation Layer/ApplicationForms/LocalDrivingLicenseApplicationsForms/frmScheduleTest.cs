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

namespace Presentation_Layer.ApplicationForms.LocalDrivingLicenseApplicationsForms
{
    public partial class frmScheduleTest : Form
    {
        private int _LDLAppID = -1;
        private int _appID = -1;
        public frmScheduleTest( enTestType type, int LDLAppID = -1 , int AppointemntID = -1)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
            _appID = AppointemntID;
            _mode = (AppointemntID == -1) ? enMode.Add : enMode.Edit;
            _testType = type;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public enum enTestType { Vision = 1, Written = 2, Street = 3}
        private enTestType _testType;
        private enum enMode { Add, Edit }
        private enMode _mode;
        private void frmScheduleTest_Load(object sender, EventArgs e)
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
            dtpDate.MinDate = DateTime.Now.AddDays(-1);

            

            clsLocalDrivingLicenseApplications app = clsLocalDrivingLicenseApplications.Find(_LDLAppID);

            lblIDValue.Text = app.LocalDrivingLicenseApplicationID.ToString();
            lblClassValue.Text = app.LicenseClassName;
            lblNameValue.Text = app.Fullname;
            lblTrialValue.Text = clsTests.GetTrialsCount(_LDLAppID, (int)_testType).ToString();
            

            if (_mode == enMode.Add)
            {
                dtpDate.Value = DateTime.Now;
                lblFeesValue.Text = clsTestTypes.Find((int)_testType).Fees.ToString();

                int RetakeID = clsTestAppointments.IsRetakeAppointment(_LDLAppID, (int)_testType);
                if (RetakeID != -1)
                {
                    gbRetakeTest.Enabled = true;
                    lblRetakeAppFeesValue.Text = "5";
                    lblTotalFeesValue.Text = (Convert.ToDecimal(lblRetakeAppFeesValue.Text) + Convert.ToDecimal(lblFeesValue.Text)).ToString();
                    lblRTestAppIDValue.Text = RetakeID.ToString();
                }
                else
                {
                    gbRetakeTest.Enabled = false;

                }


            }
            else
            {
                clsTestAppointments app1 = clsTestAppointments.Find(_appID);

                if (app1 != null)
                {
                    
                    dtpDate.Value = app1.AppointmentDate.Value;
                    lblFeesValue.Text = app1.TestFees.ToString();

                    if (app1.RetakeTestAppointmentID != -1)
                    {
                        gbRetakeTest.Enabled = true;
                        lblRetakeAppFeesValue.Text = "5";
                        lblTotalFeesValue.Text = (Convert.ToDecimal(lblRetakeAppFeesValue.Text) + Convert.ToDecimal(lblFeesValue.Text)).ToString();
                        lblRTestAppIDValue.Text = app1.RetakeTestAppointmentID.ToString();
                    }
                    else
                    {
                        gbRetakeTest.Enabled = false;
                    }

                    if (app1.IsLocked.Value)
                    {
                        lblAlreadyExists.Visible = true;
                        dtpDate.Enabled = false;
                        lblSave.Visible = false;
                    }

                }

            }

            
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            clsTestAppointments app;
            if (_mode == enMode.Add)
                app = new clsTestAppointments();
            else
                app = clsTestAppointments.Find(_appID);

            app.TestTypeID = (int)_testType;
            app.LDLAppID = _LDLAppID;
            app.AppointmentDate = dtpDate.Value;

            app.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (lblRTestAppIDValue.Text != "???")
            {
                app.PaidFees = Convert.ToDecimal(lblTotalFeesValue.Text);
                app.RetakeTestAppointmentID = Convert.ToInt32(lblRTestAppIDValue.Text);
            }
            else
            {
                app.PaidFees = Convert.ToDecimal(lblFeesValue.Text);
                

            }

            app.IsLocked = false;

            if (app.Save())
            {
                MessageBox.Show("Appointment Saved Successfully");
                this.Close();
    
            }
            else
            {
                MessageBox.Show("Something went wrong while saving. ");
            }
        }
    }
}
