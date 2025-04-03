using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaAPP
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnSalV_Click(object sender, EventArgs e)
        {
          
        }

        

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnhotelV_Click(object sender, EventArgs e)
        {
            Form10 homeForm = new Form10();
            homeForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form9 homeForm = new Form9();
            homeForm.Show();
            this.Hide();
        }
    }
}
