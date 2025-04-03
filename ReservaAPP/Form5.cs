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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurante_Click(object sender, EventArgs e)
        {
            Form10 homeForm = new Form10();
            homeForm.Show();
            this.Hide();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            Form10 homeForm = new Form10();
            homeForm.Show();
            this.Hide();
        }

        private void btnSalao_Click(object sender, EventArgs e)
        {
            Form10 homeForm = new Form10();
            homeForm.Show();
            this.Hide();
        }
    }
}
