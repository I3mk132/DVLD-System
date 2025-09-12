using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.LicenseForms
{
    public partial class frmInterLicenses : Form
    {
        public frmInterLicenses()
        {
            InitializeComponent();
        }

        private void frmInterLicenses_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmIssueInterLicense frm = new frmIssueInterLicense();
            frm.ShowDialog();
            ucIDLApplications1.RefreshDGV();
        }
    }
}
