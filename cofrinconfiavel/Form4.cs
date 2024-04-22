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
    public partial class Form4 : Form
    {
        private float valor;
        private int tempo;
        public Form4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            float resultado = valor * (float)Math.Pow(1 + 0.0887, tempo);
            MessageBox.Show("O valor ao total nesse tempo é de: " + resultado);
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float valorConvertido))
            {
                valor = valorConvertido;
            }
            else
            {
                MessageBox.Show("Valor inválido.");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int tempoConvertido))
            {
                tempo = tempoConvertido;
            }
            else
            {
                MessageBox.Show("Tempo inválido.");
            }
        }

    }
    }

