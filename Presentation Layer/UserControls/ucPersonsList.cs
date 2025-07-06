using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Presentation_Layer.PeopleForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation_Layer.UserControls
{
    public partial class ucPersonsList : UserControl
    {
        public ucPersonsList()
        {
            InitializeComponent();
            _UpdateData();
            cbFilterBy.SelectedIndex = 0;
        }
        private DataTable dt = clsPerson.GetAllPersonSimpled();
        private void _UpdateData()
        {
            dgvPersonsList.DataSource = dt;
            lblRecordCount.Text = "# Records: " + dt.Rows.Count.ToString();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
            }
            else
            {
                txtFilter.Visible = true;
            }
            _UpdateData();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string text = txtFilter.Text;
            string FilterMode = cbFilterBy.SelectedItem.ToString();
            
            if (FilterMode == "Person ID")
            {
                txtFilter.KeyPress += txtFilter_KeyPress;
            }
            else
            {
                txtFilter.KeyPress -= txtFilter_KeyPress;
            }

            if (text == "")
            {
                dt = clsPerson.GetAllPersonSimpled();
                _UpdateData();
                return;
            }
            switch (FilterMode)
            {
                case "None":
                    dt = clsPerson.GetAllPersonSimpled(); break;
                case "Person ID":
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(PersonID: Convert.ToInt32(text)); break;
                case "National No.":
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(NationalNo: text); break;
                case "First Name":
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(Firstname: text); break;
                case "Second Name":
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(Secondname: text); break;
                case "Third Name":
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(Thirdname: text); break;
                case "Last Name":
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(Lastname: text); break;
                case "Nationality":
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(NationalNo: text); break;
                case "Gender":
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(Gender: text); break;
                case "Phone":
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(Phone: text); break;
                case "Email":
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(Email: text); break;
            }
            
            _UpdateData();
        }

        private void cmsiShowDetails_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails();
            frm.ShowDialog();
        }

        private void cmsiAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
        }

        private void cmsiEdit_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
        }

        private void cmsiDelete_Click(object sender, EventArgs e)
        {
            // delete item
        }
    }
}
