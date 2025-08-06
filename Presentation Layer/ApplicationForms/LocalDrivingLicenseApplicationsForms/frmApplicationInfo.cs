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
    public partial class frmApplicationInfo : Form
    {
        public frmApplicationInfo(int LDLAppID)
        {
            InitializeComponent();
            ucDLApplicationInfo1.AppID = LDLAppID;
        }

        private void frmApplicationInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
