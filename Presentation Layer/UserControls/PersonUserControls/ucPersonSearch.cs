using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Presentation_Layer.PeopleForms;

namespace Presentation_Layer.UserControls
{
    public partial class ucPersonSearch : UserControl
    {
        public ucPersonSearch()
        {
            InitializeComponent();
            cbFilterBy.SelectedIndex = 0;
        }
        private clsPerson _person = null;

        private void ucPersonSearch_Load(object sender, EventArgs e)
        {

        }

        public bool ActivateForm
        {
            set
            {
                if (value)
                {
                    cbFilterBy.Enabled = true;
                    txtFilter.Enabled = true;
                    btnAdd.Enabled = true;
                    btnFind.Enabled = true;
                }
                else
                {
                    cbFilterBy.Enabled = false;
                    txtFilter.Enabled = false;
                    btnAdd.Enabled = false;
                    btnFind.Enabled = false;
                }
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFilter.Text = string.Empty;
            txtFilter.Focus();
            

            if (cbFilterBy.Text == "Person ID")
            {
                txtFilter.KeyPress += txtFilter_KeyPress;
            }
            else
            {
                txtFilter.KeyPress -= txtFilter_KeyPress;
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
            
            if (frm.personID != -1)
            {
                LoadPersonDetails(frm.personID);
                DataBack?.Invoke(this, frm.personID);
            }
        }


        public delegate void DataBackEventHandler(object sender, int personID);
        public event DataBackEventHandler DataBack;
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
            {
                return;
            }
            switch (cbFilterBy.Text)
            {
                case "Person ID": _person = clsPerson.Find(PersonID: Convert.ToInt32(txtFilter.Text)); break;
                case "National No.": _person = clsPerson.Find(NationalNo: txtFilter.Text); break;
                case "First Name": _person = clsPerson.Find(Firstname: txtFilter.Text); break;
                case "Second Name": _person = clsPerson.Find(Secondname: txtFilter.Text); break;
                case "Third Name": _person = clsPerson.Find(Thirdname: txtFilter.Text); break;
                case "Last Name": _person = clsPerson.Find(Lastname: txtFilter.Text); break;
                case "Nationality": _person = clsPerson.Find(Country: txtFilter.Text); break;
                case "Gender": _person = clsPerson.Find(Gender: txtFilter.Text); break;
                case "Phone": _person = clsPerson.Find(Phone: txtFilter.Text); break;
                case "Email": _person = clsPerson.Find(Email: txtFilter.Text); break;
            }

            if (_person == null)
            {
                if (MessageBox.Show(
                    "Person isn't exists. Do you want to add a new Person ? ", 
                    "Add person", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    btnAdd.PerformClick();
                }
            }
            else
            {

                LoadPersonDetails(_person.PersonID);
                DataBack?.Invoke(this, _person.PersonID);
            }
        }

        private void ucPersonDetails1_Load(object sender, EventArgs e)
        {
            
        }
        public void LoadPersonDetails(int PersonID)
        {
            ucPersonDetails1.PersonID = PersonID;
            ucPersonDetails1.LoadPersonData();
        }
    }
}
