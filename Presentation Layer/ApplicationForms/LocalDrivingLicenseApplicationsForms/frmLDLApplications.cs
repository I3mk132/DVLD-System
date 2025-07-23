using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.ApplicationForms.LocalDrivingLicenseApplicationsForms
{
    public partial class frmLDLApplications : Form
    {
        public frmLDLApplications()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmAddEditLDLApplication frm = new frmAddEditLDLApplication();
            frm.ShowDialog();
            RefreshDGV();

        }

        private void frmLDLApplications_Load(object sender, EventArgs e)
        {
            
        }

        private void RefreshDGV() => ucLDLApplications1.RefreshDGV();
    }
}
