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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar1_Click(object sender, EventArgs e)
        {
            Form2 homeForm = new Form2();
            homeForm.Show();
            this.Hide();
        }

        private void btnCriarempresa_Click(object sender, EventArgs e)
        {
            Form4 homeForm = new Form4();
            homeForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
