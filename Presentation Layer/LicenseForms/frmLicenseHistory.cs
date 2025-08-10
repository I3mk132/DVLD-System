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

namespace Presentation_Layer.LicenseForms
{
    public partial class frmLicenseHistory : Form
    {
        private int _PersonID = -1;
        public frmLicenseHistory(int personID)
        {
            InitializeComponent();
            _PersonID = personID;

        }



        DataTable LocalDt = null, InternationalDt = null;
        private void _UpdateData()
        {
            dgvLocalLicenses.DataSource = LocalDt;
            lblRecordCountLocal.Text = "# Records: " + LocalDt.Rows.Count.ToString();

            dgvInternationalLicenses.DataSource = InternationalDt;
            lblRecordCountInter.Text = "# Records: " + InternationalDt.Rows.Count.ToString();
        }
        public void RefreshDGV()
        {
            LocalDt = clsLicenses.GetAllFor(_PersonID);
            InternationalDt = clsInternationalLicenses.GetAllFor(_PersonID);
            _UpdateData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            ucPersonSearch1.LoadPersonDetails(_PersonID);
            ucPersonSearch1.ActivateForm = false;
            RefreshDGV();
        }


    }
}
