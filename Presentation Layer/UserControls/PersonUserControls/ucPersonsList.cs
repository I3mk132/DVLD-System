using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation_Layer.UserControls
{
    public partial class ucPersonsList : UserControl
    {
        public ucPersonsList()
        {
            InitializeComponent();
            RefreshData();
            cbFilterBy.SelectedIndex = 0;
        }
        private DataTable dt = clsPerson.GetAllPersonSimpled();
        private void _UpdateData()
        {
            dgvPersonsList.DataSource = dt;
            lblRecordCount.Text = "# Records: " + dt.Rows.Count.ToString();
        }
        public void RefreshData()
        {
            dt = clsPerson.GetAllPersonSimpled();
            _UpdateData();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
                txtFilter.Text = string.Empty;
            }
            else
            {
                txtFilter.Visible = true;
                txtFilter.Focus();
            }
            _AddFilter();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void _AddFilter()
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
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(Country: text); break;
                case "Gender":
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(Gender: text); break;
                case "Phone":
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(Phone: text); break;
                case "Email":
                    dt = clsPerson.GetPeopleUsingLikeSimpledWith(Email: text); break;
            }

            _UpdateData();

        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _AddFilter();
        }

        private void cmsiShowDetails_Click(object sender, EventArgs e)
        {
            if (dgvPersonsList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvPersonsList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int personId = Convert.ToInt32(row.Cells[0].Value);
                frmPersonDetails frm = new frmPersonDetails(personId);
                frm.ShowDialog();
            }

            RefreshData();
        }

        private void cmsiAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();

            RefreshData();
        }

        private void cmsiEdit_Click(object sender, EventArgs e)
        {
            if (dgvPersonsList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvPersonsList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int personId = Convert.ToInt32(row.Cells[0].Value);
                frmAddEditPerson frm = new frmAddEditPerson(personId);
                frm.ShowDialog();
            }
            RefreshData();
        }

        private void cmsiDelete_Click(object sender, EventArgs e)
        {
            if (dgvPersonsList.SelectedCells.Count > 0)
            {
                if (MessageBox.Show(
                    "Are you sure you want to delete person ? ",
                    "Person delete",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    DataGridViewCell selectedCell = dgvPersonsList.SelectedCells[0];
                    DataGridViewRow row = selectedCell.OwningRow;

                    int personId = Convert.ToInt32(row.Cells[0].Value);
                    clsPerson person = clsPerson.Find(personId);

                    string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Pictures", person.ImagePath);
                    if (File.Exists(imagePath))
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        File.Delete(imagePath);
                    }

                    if (clsPerson.DeletePerson(personId))
                        MessageBox.Show("Person Deleted Successfully");
                    else
                        MessageBox.Show("Person Couldnt be deleted because there are some data linked to it");
                }
            }

            RefreshData();

        }


        public void FilterToNone()
        {
            txtFilter.Text = string.Empty;
            txtFilter.Visible = false;
            cbFilterBy.SelectedIndex = 0;
            RefreshData();
        }
    }
}
