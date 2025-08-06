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
using Presentation_Layer.Properties;

namespace Presentation_Layer.ApplicationForms.LocalDrivingLicenseApplicationsForms
{
    public partial class frmScheduleTestAppointments : Form
    {
        private int _LDLAppID = -1, _testTypeID = -1;
        public frmScheduleTestAppointments(int LDLAppID, int TestTypeID)
        {
            InitializeComponent();

            ucDLApplicationInfo1.AppID = LDLAppID;
            ucApplicaitonBasicInfo1.AppID = clsLocalDrivingLicenseApplications.Find(LDLAppID).ApplicationID;
            this._LDLAppID = LDLAppID;
            this._testTypeID = TestTypeID;
        }

        private void RefreshDGV()
        {
            dataGridView1.DataSource = clsTestAppointments.GetAllTestAppointmentsFor(_LDLAppID, _testTypeID);
            lblRecordCount.Text = "# Records: " + dataGridView1.RowCount.ToString();
            

        }
        private void frmScheduleTestAppointments_Load(object sender, EventArgs e)
        {
            RefreshDGV();
            
            switch (_testTypeID)
            {
                case 1:
                    this.Text = "Vision Test Appointments";
                    lblTestAppointments.Text = "Vision Test Appointments";
                    pbIcon.Image = Resources.eye;
                    break;
                case 2:
                    this.Text = "Written Test Appointments";
                    lblTestAppointments.Text = "Written Test Appointments";
                    pbIcon.Image = Resources.Test;
                    break;
                case 3:
                    this.Text = "Street Test Appointments";
                    lblTestAppointments.Text = "Street Test Appointments";
                    pbIcon.Image = Resources.Driver;
                    break;
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (clsTestAppointments.HasUnlockedAppointment(_LDLAppID, _testTypeID))
            {
                MessageBox.Show("Person Already have an active appointemnt for this test, You cannot add a new appointment. ", "Not Allowed");
                return;
            }
            if (clsTests.TestPassed(_LDLAppID, _testTypeID))
            {
                MessageBox.Show("Person Already Passed the test. ");
                return;
            }

            frmScheduleTest frm = new frmScheduleTest((frmScheduleTest.enTestType)_testTypeID, _LDLAppID);
            frm.ShowDialog();
            RefreshDGV();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int AppointmentID = Convert.ToInt32(row.Cells[0].Value);

                frmScheduleTest frm = new frmScheduleTest((frmScheduleTest.enTestType)_testTypeID, _LDLAppID, AppointmentID);
                
                frm.ShowDialog();
                RefreshDGV();
            }

        }

        private void cms_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                bool IsLocked = Convert.ToBoolean( row.Cells[3].Value );

                if (IsLocked)
                {
                    tsmiEdit.Enabled = false;
                    tsmiTakeTest.Enabled = false;
                }
                else
                {
                    tsmiTakeTest.Enabled = true;
                    tsmiEdit.Enabled = true;
                }
            }
        }

        private void tsmiTakeTest_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;

                int AppointmentID = Convert.ToInt32(row.Cells[0].Value);
                frmTakeTest frm = new frmTakeTest((frmTakeTest.enTestType)_testTypeID, _LDLAppID, AppointmentID);

                frm.ShowDialog();
                RefreshDGV();
            }
        }
    }
}
