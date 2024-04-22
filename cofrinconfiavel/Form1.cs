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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 cadastro = new Form2();
            cadastro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
                Form3 form3 = new Form3();
                form3.ShowDialog();
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Senha = textBox2.Text;
            string senhaOculta = new string('*', Senha.Length);
            textBox2.Text = senhaOculta;
            textBox2.SelectionStart = textBox2.Text.Length;
        
        }
    }
}
