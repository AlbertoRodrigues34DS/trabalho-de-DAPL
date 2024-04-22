using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace cofrinconfiavel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
            TxtSenha.PasswordChar = '*';
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TxtSenha.PasswordChar = '*';
            
    }

        private void button2_Click(object sender, EventArgs e)
        {
            if(TxtconSenha.Text==TxtSenha.Text)
            { 
            Cadastro cliente1 = new Cadastro( TxtEmail.Text, TxtSenha.Text);
                string hashsenha = TxtSenha.Text.GetHashCode().ToString();
                string path = (@"C:\Cadastro\Usuários\" + TxtEmail.Text + ".txt");
                try
                {
                    if (File.Exists(path))
                    {
                        return;
                    }
                    else
                    {
                        using (var sw = File.CreateText(path))
                        {
                            sw.WriteLine(TxtSenha.Text);
                            string hashedPassword = TxtSenha.Text.GetHashCode().ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("erro ao criar o aquivo");
                }
                try
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(hashsenha);
                        MessageBox.Show("ok");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("erro");
                }
            }
            else
            {
                MessageBox.Show("A senha está incorreta");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

     
    }
}
