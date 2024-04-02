using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desenvolvimento_do_uia
{
    public partial class confirmar : Form
    {
        public confirmar()
        {
            InitializeComponent();
        }

        private void confimar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (!email.Contains ("gmail.com")||!email.Contains ("hotmail.com"))
            {
                MessageBox.Show("O  email está incorreto, por favor verifique o email e tente novamente.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void confirmar_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            string senha
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
            pictureBox1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            pictureBox1.Visible = false;
        }
    }
}
