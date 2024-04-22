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
    public partial class Form7 : Form
    {
        private float valor4 = 0;
        private int tempo4 = 0;
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float valor4 =float.Parse(textBox1.Text);   
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int tempo4=int.Parse(textBox2.Text);    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float resultado4 = valor4 * (float)Math.Pow(1 + 0.085, tempo4);
            MessageBox.Show("O valor ao total nesse tempo é de: " + resultado4);
        }
    }
}
