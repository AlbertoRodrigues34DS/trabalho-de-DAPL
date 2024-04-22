using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cofrinconfiavel
{
    public partial class Form5 : Form
    {
        private float valor5;
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float valor5= float.Parse(textBox1.Text);   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float resultado = valor5 * (float)Math.Pow(1 + 0.1155 , 1);
            MessageBox.Show("O valor ao total nesse tempo é de: " + resultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float resultado = valor5 * (float)Math.Pow(1 + 0.1235, 2);
            MessageBox.Show("O valor ao total nesse tempo é de: " + resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float resultado = valor5 * (float)Math.Pow(1 + 0.127, 3);
            MessageBox.Show("O valor ao total nesse tempo é de: " + resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float resultado5 = valor5 * (float)Math.Pow(1 + 0.13, 4);
            MessageBox.Show("O valor ao total nesse tempo é de: " + resultado5);
        }
    }
}
