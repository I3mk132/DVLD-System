using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.PeopleForms
{
    public partial class frmPersonDetails : Form
    {
        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();
            ucPersonDetails1.PersonID = PersonID;
        }
        
        private void frmPersonDetails_Load(object sender, EventArgs e)
        {

        }

        private void ucPersonDetails1_Load(object sender, EventArgs e)
        {

        }
    }
}
