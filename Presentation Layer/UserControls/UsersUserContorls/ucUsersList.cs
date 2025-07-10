using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Presentation_Layer.PeopleForms;
using Presentation_Layer.UserForms;
using static System.Net.Mime.MediaTypeNames;

namespace Presentation_Layer.UserControls
{
    public partial class ucUsersList : UserControl
    {
        public ucUsersList()
        {
            InitializeComponent();
            ucUserFilter1.DataBack += _AddFilter_Event;
            RefreshData();
        }
        DataTable dt = null;
        private void _UpdateData()
        {
            dgvUsersList.DataSource = dt;
            lblRecordCount.Text = "# Records: " + dt.Rows.Count.ToString();
        }
        public void RefreshData()
        {
            dt = clsUsers.GetAllUsersSimpled();
            _UpdateData();
        }

        private void _AddFilter_Event(object sender)
        {
            _AddFilter();
        }
        private void _AddFilter()
        {

            string FilterMode = ucUserFilter1.FilterBy;
            string text = ucUserFilter1.FilterValue;

            if (text == "")
            {
                dt = clsUsers.GetAllUsersSimpled();
                _UpdateData();
                return;
            }
            switch (FilterMode)
            {
                case "None":
                    dt = clsUsers.GetAllUsersSimpled(); break;
                case "User ID":
                    dt = clsUsers.GetUsersSimpledUsingLikeWith(UserID: Convert.ToInt32(text)); break;
                case "Username":
                    dt = clsUsers.GetUsersSimpledUsingLikeWith(Username: text); break;
                case "Person ID":
                    dt = clsUsers.GetUsersSimpledUsingLikeWith(PersonID: Convert.ToInt32(text)); break;
                case "Fullname":
                    dt = clsUsers.GetUsersSimpledUsingLikeWith(Firstname: text, Secondname: text, Thirdname: text, Lastname: text); break;
                case "Is Active":
                    dt = clsUsers.GetUsersSimpledUsingLikeWith(IsActive: (text == "1")); break;

            }

            _UpdateData();

        }



        private void cmsiChangePassword_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvUsersList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int personId = Convert.ToInt32(row.Cells[1].Value);
                int userId = Convert.ToInt32(row.Cells[0].Value);
                frmChangePassword frm = new frmChangePassword(userId, personId);
                frm.ShowDialog();
            }
            
        }
        private void cmsiShowDetails_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvUsersList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int UserID = Convert.ToInt32(row.Cells[0].Value);
                int PersonID = Convert.ToInt32(row.Cells[1].Value);

                frmUserDetails frm = new frmUserDetails(UserID, PersonID);
                frm.ShowDialog();
            }

            RefreshData();
        }

        private void cmsiAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();

            RefreshData();
        }

        private void cmsiEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvUsersList.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int UserID = Convert.ToInt32(row.Cells[0].Value);

                frmAddEditUser frm = new frmAddEditUser(); // UserID
                frm.ShowDialog();
            }
            RefreshData();
        }

        private void cmsiDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.SelectedCells.Count > 0)
            {
                if (MessageBox.Show(
                    "Are you sure you want to delete person ? ",
                    "Person delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    DataGridViewCell selectedCell = dgvUsersList.SelectedCells[0];
                    DataGridViewRow row = selectedCell.OwningRow;

                    int UserID = Convert.ToInt32(row.Cells[0].Value);
                    clsUsers user = clsUsers.Find(UserID);

                    if (clsUsers.DeleteUser(UserID))
                        MessageBox.Show("User Deleted Successfully");
                    else
                        MessageBox.Show("User Couldnt be deleted because there are some data linked to it");
                }
            }

            RefreshData();

        }
        public void cmsiStillNotWorking_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Still not working");
        }

        public void FilterToNone()
        {
            ucUserFilter1.setFilterToNone();
            RefreshData();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvUsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
