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

namespace Presentation_Layer.UserControls.DriverUserControls
{
    public partial class ucDriversList : UserControl
    {
        public ucDriversList()
        {
            InitializeComponent();
            RefreshData();
            cbFilterBy.SelectedIndex = 0;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        DataTable dt = null;
        private void _UpdateData()
        {
            dgvDriversList.DataSource = dt;
            lblRecordCount.Text = "# Records: " + dt.Rows.Count.ToString();
        }
        public void RefreshData()
        {
            dt = clsDrivers.GetallDriversSimpled();
            _UpdateData();
        }

                
        private void _AddFilter()
        {

            string FilterMode = FilterBy;
            string text = FilterValue;

            if (text == "")
            {
                RefreshData();
                return;
            }
            switch (FilterMode)
            {
                case "None":
                    dt = clsDrivers.GetallDriversSimpled(); break;
                case "Driver ID":
                    dt = clsDrivers.GetAllDriversFiltered(DriverID:Convert.ToInt32(text)); break;
                case "Person ID":
                    dt = clsDrivers.GetAllDriversFiltered(PersonID: Convert.ToInt32(text)); break;
                case "Full Name":
                    dt = clsDrivers.GetAllDriversFiltered(Fullname: text); break;
                case "National No.":
                    dt = clsDrivers.GetAllDriversFiltered(NationalNo: text); break;

            }

            _UpdateData();

        }

        public string FilterBy = "";
        public string FilterValue = "";

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filterMode = cbFilterBy.Text;
            FilterBy = filterMode;
            txtFilter.Text = "";

            if (filterMode == "Driver ID" || filterMode == "Person ID")
                txtFilter.KeyPress += txtFilter_KeyPress;
            else
                txtFilter.KeyPress -= txtFilter_KeyPress;


            if (filterMode == "None")
            {
                txtFilter.Visible = false;
            }
            else
            {
                txtFilter.Visible = true;
                txtFilter.Focus();

            }
            _AddFilter();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            FilterValue = txtFilter.Text;
            _AddFilter();
        }


    }
}
