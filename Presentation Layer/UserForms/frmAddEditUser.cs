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
    public partial class frmAddEditUser : Form
    {
        public frmAddEditUser()
        {
            InitializeComponent();
            ucPersonSearch1.DataBack += fillPersonCard;
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {

        }

        private void fillPersonCard(object sender, int PersonID) 
        {
            ucPersonDetails1.PersonID = PersonID;
            ucPersonDetails1.LoadPersonData();
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
            // Save User Function. 
        }

        private ErrorProvider error = new ErrorProvider();
        private string OldUsername, OldPassword;
        private bool errorFlag = false;
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;

            clsUsers user = clsUsers.Find(Username: Username);
            if (user != null && Username != OldUsername)
            {
                error.SetError(txtUsername, "Username is already exists");
                errorFlag = true;
            }
        }
    }
}
