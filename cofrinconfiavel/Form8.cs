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
    public partial class Form8 : Form
    {
        private float  valor3 = 0;
        private int tempo3 = 0  ;
        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float valor3=float.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int tempo3 = int.Parse(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float resultado3 = valor3 * (float)Math.Pow(1 + 0.10165, tempo3);
            MessageBox.Show("O valor ao total nesse tempo é de: " + resultado3);
        }
    }
}
