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

namespace Presentation_Layer.UserForms
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword(int UserID, int PersonID)
        {
            InitializeComponent();
            ucLoginInfo1.UserID = UserID;
            ucPersonDetails1.PersonID = PersonID;
            user = clsUsers.Find(UserID: UserID);
        }
        clsUsers user;
        private bool _errorFlag = false;
        ErrorProvider Error = new ErrorProvider(); 
        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ComparePasswords();

            if (_errorFlag)
            {
                MessageBox.Show("Fix Provided Errors. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            user.Password = txtPassword.Text;
            string encryptedPassword =  user.Password.Substring(0, 2)
                                        + new string('*', user.Password.Length - 4)
                                        + user.Password.Substring(user.Password.Length - 2, 2);

            if (MessageBox.Show(
                $"Are you sure you want to change password To {encryptedPassword}? ", 
                "Change Password", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }

            if (user.Save())
            {
                MessageBox.Show("Password Saved Successfully", "Success!", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Something wont wrong while saving. ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void txtCurrentPassword_Leave(object sender, EventArgs e)
        {
            if (!clsUsers.VerifyPassword(txtCurrentPassword.Text, user.Password))
            {
                _errorFlag = true;
                Error.SetError(txtCurrentPassword, "Entered password is wrong. ");
            }
            else
            {
                _errorFlag = false;
                Error.SetError(txtCurrentPassword, "");
            }
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
            Error.SetError(txtConfirmPassword, errorMessage);
            Error.SetError(txtPassword, errorMessage);
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            _ComparePasswords();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            _ComparePasswords();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            _ComparePasswords();
        }
    }
}
