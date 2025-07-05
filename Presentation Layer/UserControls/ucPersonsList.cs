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

namespace Presentation_Layer.UserControls
{
    public partial class ucPersonsList : UserControl
    {
        public ucPersonsList()
        {
            InitializeComponent();
            _UpdateData();
        }
        private DataTable dt = clsPerson.GetAllPerson();
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string text = txtFilter.Text;
            switch (cbFilterBy.SelectedItem.ToString())
            {
                case "None":
                    dt = clsPerson.GetAllPerson(); break;
                case "Person ID":
                    dt = clsPerson.GetPeopleWith(PersonID: Convert.ToInt32(text)); break;    
                case "National No.":
                    dt = clsPerson.GetPeopleWith(NationalNo: text); break;
                case "First Name":
                    dt = clsPerson.GetPeopleWith(Firstname: text); break;
                case "Second Name":
                    dt = clsPerson.GetPeopleWith(Secondname: text); break;
                case "Third Name":
                    dt = clsPerson.GetPeopleWith(Thirdname: text); break;
                case "Last Name":
                    dt = clsPerson.GetPeopleWith(Lastname: text); break;
                case "Nationality":
                    dt = clsPerson.GetPeopleWith(NationalNo: text); break;
                case "Gender":
                    dt = clsPerson.GetPeopleWith(Gender: Convert.ToInt16(text)); break;
                case "Phone":
                    dt = clsPerson.GetPeopleWith(Phone: text); break;
                case "Email":
                    dt = clsPerson.GetPeopleWith(Email: text); break;
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
