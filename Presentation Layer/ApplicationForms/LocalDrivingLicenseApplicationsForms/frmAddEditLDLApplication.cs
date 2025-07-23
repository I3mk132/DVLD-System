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

namespace Presentation_Layer.ApplicationForms.LocalDrivingLicenseApplicationsForms
{
    public partial class frmAddEditLDLApplication : Form
    {
        private enum _enMode { eAdd, eUpdate }
        _enMode Mode;
        private int _LDLApplicationID = -1;
        private int _PersonID = -1;
        private DateTime? _Date = null;
        public frmAddEditLDLApplication(int LDLApplicationID = -1)
        {
            InitializeComponent();
            ucPersonSearch1.DataBack += fillPersonCard;

            if (LDLApplicationID == -1)
            {
                Mode = _enMode.eAdd;
            }
            else
            {
                Mode = _enMode.eUpdate;
                this._LDLApplicationID = LDLApplicationID;
            }
        }

        private void frmAddEditLDLApplication_Load(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplications app;
            cbLicenseClasses.Items.AddRange(clsLocalDrivingLicenseApplications.GetAllLicenseClasses().ToArray());
            if (Mode == _enMode.eUpdate)
            {
                app = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID: _LDLApplicationID);

                ucPersonSearch1.LoadPersonDetails(app.PersonID);

                ucPersonSearch1.ActivateForm = false;

                lblDLAppIDValue.Text = app.LocalDrivingLicenseApplicationID.ToString();
                lblApplicationDateValue.Text = app.ApplicationDate.Value.ToString("d");
                _Date = app.ApplicationDate.Value;
                cbLicenseClasses.SelectedItem = app.LicenseClassName;
                lblApplicationFeesValue.Text = clsApplicationTypes.Find(1).Fees.ToString();
                lblCreatedByValue.Text = app.CreatedByUsername;


                lblAddEditTitle.Text = "Edit Local Driving License Application";
                this.Text = "Edit Local Driving License Application";
            }
            else
            {

                lblDLAppIDValue.Text = "N/A";
                lblApplicationDateValue.Text = DateTime.Now.ToString("d");
                _Date = DateTime.Now;
                cbLicenseClasses.SelectedIndex = 0;
                lblApplicationFeesValue.Text = clsApplicationTypes.Find(1).Fees.ToString();
                lblCreatedByValue.Text = clsGlobal.CurrentUser.Username;
                ucPersonSearch1.ActivateForm = true;

                lblAddEditTitle.Text = "Add Local Driving License Application";
                this.Text = "Add Local Driving License Application";

            }
        }

        private void fillPersonCard(object sender, int PersonID)
        {
            _PersonID = PersonID;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                clsLocalDrivingLicenseApplications app;
                if (Mode == _enMode.eUpdate)
                {
                    app = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID: _LDLApplicationID);
                }
                else
                {
                    app = new clsLocalDrivingLicenseApplications();
                    app.PersonID = _PersonID;
                    app.ApplicationDate = _Date;
                    app.PaidFees = Convert.ToDecimal(lblApplicationFeesValue.Text);
                    app.CreatedByUsername = lblCreatedByValue.Text;
                }

                app.LicenseClassName = cbLicenseClasses.Text;
                app.ApplicationStatus = "New";
                app.LastStatusDate = DateTime.Now;
                app.ApplicationTypeID = 1;


                if (!clsLocalDrivingLicenseApplications.IsApplicationExists(app.PersonID, app.LicenseClassID))
                {

                    if (app.Save())
                    {
                        MessageBox.Show(
                            "application saved successfully. ",
                            "Done",
                            MessageBoxButtons.OK);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Something went wrong while saving Application. ",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "This Application is already exists, Choose another License Class",
                        "Error",
                        MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Choose Person Before Saving. ", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
