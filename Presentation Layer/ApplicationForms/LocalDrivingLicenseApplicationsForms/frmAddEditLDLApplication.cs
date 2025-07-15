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
            if (Mode == _enMode.eUpdate)
            {
                app = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID: _LDLApplicationID);

                ucPersonSearch1.LoadPersonDetails(app.PersonID);

                ucPersonSearch1.ActivateForm = false;

                lblDLAppIDValue.Text = app.ApplicationID.ToString();
                lblApplicationDateValue.Text = app.ApplicationDate.Value.ToString("d");
                cbLicenseClasses.SelectedText = app.ClassName;
                lblApplicationFeesValue.Text = app.PaidFees.ToString();
                lblCreatedByValue.Text = clsapp.CreatedByUserID;


                lblAddEditTitle.Text = "Edit User";
                this.Text = "Edit User";
            }
            else
            {

                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtConfirmPassword.Text = string.Empty;
                lblDLAppIDValue.Text = "N/A";
                chkIsActive.Checked = true;
                ucPersonSearch1.ActivateForm = true;

                lblAddEditTitle.Text = "Add User";
                this.Text = "Add User";

            }

        private void fillPersonCard(object sender, int PersonID)
        {
            if (Mode == _enMode.eAdd && clsUsers.Find(PersonID: PersonID) != null)
            {
                MessageBox.Show("This person already have data linked to it. ");
                return;
            }
            //ucPersonDetails1.PersonID = PersonID;
            //ucPersonDetails1.LoadPersonData();
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
            if (!_errorFlag && _PersonID != -1)
            {
                clsUsers user;
                if (Mode == _enMode.eUpdate)
                    user = clsUsers.Find(UserID: _UserID);
                else
                {
                    user = new clsUsers();
                    user.PersonID = _PersonID;
                }



                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.IsActive = chkIsActive.Checked;

                if (user.Save())
                {
                    MessageBox.Show(
                        "User saved successfully. ",
                        "Done",
                        MessageBoxButtons.OK);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Something went wrong while saving user. ",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }


        }


    }
}
