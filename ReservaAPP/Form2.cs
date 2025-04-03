using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReservaAPP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string usuario, senha, confirma;
            usuario = textBox1.Text;
            senha = textBox3.Text;
            confirma = textBox4.Text;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
            saveFileDialog.Title = "Salvar Arquivo";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = "arquivo";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    writer.WriteLine($"Usuário: {usuario}");
                    writer.WriteLine($"Senha: {senha}");
                }

            }

            if (!string.IsNullOrWhiteSpace(usuario) && !string.IsNullOrWhiteSpace(senha) && !string.IsNullOrWhiteSpace(confirma) && senha == confirma)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
                Form5 homeForm = new Form5();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Não foi possível realizar seu cadastro no momento. Cheque as informações e tente novamente.");
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            homeForm.Show();
            this.Hide();
        }
    }
    }

