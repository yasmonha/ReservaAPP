using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace ReservaAPP
{
    public partial class Form4 : Form
    {
        private string configPath = "cadastros.txt"; // Arquivo para armazenar os cadastros

        public Form4()
        {
            InitializeComponent();
        }

        private void btnCadastroEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeEmpresa = textBox1.Text.Trim();
                string cnpj = textBox3.Text.Trim();
                string email = textBox2.Text.Trim();

                if (string.IsNullOrEmpty(nomeEmpresa) || string.IsNullOrEmpty(cnpj) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                    return;
                }

                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Por favor, insira um e-mail válido.");
                    return;
                }

                // Salvar os dados no arquivo
                SalvarCadastro(nomeEmpresa, cnpj, email);

                // Enviar e-mail de confirmação
                EnviarEmailConfirmacao(nomeEmpresa, email);

                MessageBox.Show("Cadastro realizado com sucesso! Um e-mail de confirmação foi enviado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnV2_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            homeForm.Show();
            this.Hide();
        }

        private void SalvarCadastro(string nomeEmpresa, string cnpj, string email)
        {
            using (StreamWriter sw = File.AppendText(configPath))
            {
                sw.WriteLine($"Empresa: {nomeEmpresa} | CNPJ: {cnpj} | Email: {email}");
            }
        }

        private void EnviarEmailConfirmacao(string nomeEmpresa, string destinatario)
        {
            try
            {
                string remetente = "yasmim.ribeiro5005@gmail.com"; // Altere para seu e-mail
                string senha = "xzpr vqrv xzxc ditj"; // Altere para sua senha ou senha de app

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(remetente);
                mail.To.Add(destinatario);
                mail.Subject = "Confirmação de Cadastro - Reserva APP";
                mail.Body = $"Olá {nomeEmpresa},\n\nObrigado por se cadastrar! Seu cadastro foi recebido com sucesso.";
                mail.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(remetente, senha);
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
