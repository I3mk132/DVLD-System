using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Presentation_Layer.UserForms
{
    public partial class frmAddEditUser : Form
    {
        private enum _enMode { eAdd, eUpdate }
        _enMode Mode;
        private int _UserID;
        private int _PersonID = -1;
        public frmAddEditUser(int UserID = -1)
        {
            InitializeComponent();
            ucPersonSearch1.DataBack += fillPersonCard;

            if (UserID == -1)
            {
                Mode = _enMode.eAdd;
            }
            else
            {
                Mode = _enMode.eUpdate;
                this._UserID = UserID;
            }
        }
        

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            clsUsers user;
            if (Mode == _enMode.eUpdate)
            {
                user = clsUsers.Find(UserID: _UserID);

                ucPersonDetails1.PersonID = user.PersonID;
                ucPersonDetails1.LoadPersonData();

                _OldUsername = user.Username;
                _PersonID = user.PersonID;

                ucPersonSearch1.ActivateForm = false;
                txtUsername.Text = user.Username;
                lblUserIDValue.Text = user.UserID.ToString();
                chkIsActive.Checked = user.IsActive.Value;


                lblAddEditTitle.Text = "Edit User";
                this.Text = "Edit User";
            }
            else
            {
                
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtConfirmPassword.Text = string.Empty;
                lblUserIDValue.Text = "N/A";
                chkIsActive.Checked = true;
                ucPersonSearch1.ActivateForm = true;

                lblAddEditTitle.Text = "Add User";
                this.Text = "Add User";
            }
        }

        private void fillPersonCard(object sender, int PersonID) 
        {
            if (Mode == _enMode.eAdd && clsUsers.Find(PersonID: PersonID) != null)
            {
                MessageBox.Show("This person already have data linked to it. ");
                return;
            }
            ucPersonDetails1.PersonID = PersonID;
            ucPersonDetails1.LoadPersonData();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private ErrorProvider error = new ErrorProvider();
        private string _OldUsername;
        private bool _errorFlag = false;
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string errorString = "";

            clsUsers user = clsUsers.Find(Username: Username);
            if (user != null && Username != _OldUsername)
            {
                errorString = "Username is already exists";
                _errorFlag = true;
            }
            else
            {
                errorString = "";
                _errorFlag = false;
            }
            error.SetError(txtUsername, errorString);
        }

        private void _ComparePasswords()
        {
            string errorMessage = "";
            if (!string.Equals(txtConfirmPassword.Text, txtPassword.Text))
            {
                errorMessage = "Entered Passwords aren't the same. ";
                _errorFlag = true;
            }
            else
            {
                errorMessage = "";
                _errorFlag = false;
            }
            error.SetError(txtConfirmPassword, errorMessage);
            error.SetError(txtPassword, errorMessage);
        }
        private void _CheckPasswordLength()
        {
            string errorMessage = "";
            if (txtPassword.Text.Length < 8)
            {
                errorMessage = "Password should at least contain 8 Characters. ";
                _errorFlag = true;
            }
            else
            {
                errorMessage = "";
                _errorFlag = false;
            }
            error.SetError(txtPassword, errorMessage);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            _ComparePasswords();
            _CheckPasswordLength();
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            _ComparePasswords();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            _ComparePasswords();
        }

        private void tbPersonalInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
