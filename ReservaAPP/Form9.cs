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
    public partial class Form9 : Form
    {
        public bool CheckBoxMarcada { get; set; }
        public Form9()
        {
            InitializeComponent();
            if (CheckBoxMarcada)
            {
                // Exibe o texto na label se a CheckBox estiver marcada
                label1.Text = "Bistro Encantado - 11:00";
            }
            else
            {
                // Caso contrário, a label fica vazia
                label1.Text = "";
            }
        }

        private void btnhotelV_Click(object sender, EventArgs e)
        {
            Form5 homeForm = new Form5();
            homeForm.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
