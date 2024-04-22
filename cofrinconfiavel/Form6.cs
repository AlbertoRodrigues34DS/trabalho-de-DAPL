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
    public partial class Form6 : Form
    {
        private float valor2=0;
        private int tempo2=0;
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            float resultado2 = valor2 * (float)Math.Pow(1 + 0.1017, tempo2);
            MessageBox.Show("O valor ao total nesse tempo é de: " + resultado2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int tempo2=int.Parse(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float valor2=float.Parse(textBox1.Text);
        }
    }
}
