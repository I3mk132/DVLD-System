using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation_Layer.PeopleForms;

namespace Presentation_Layer
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void msiPeople_Click(object sender, EventArgs e)
        {
            frmPeople people = new frmPeople();
            people.ShowDialog();
        }


        public bool QuitFlag = true;
        private void msiSignout_Click(object sender, EventArgs e)
        {
            QuitFlag = false;
            this.Close();
        }
    }
}
