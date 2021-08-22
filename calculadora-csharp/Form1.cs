using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_csharp
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0; 
        decimal valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn9.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn6.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn3.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn2.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn1.Text;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            string virgula = ".";
            textBox1.Text = virgula;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn0.Text;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "SOMA";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "DIV";
        }

        private void btnMultipli_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "MULTI";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "MENOS";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                textBox1.Text = Convert.ToString(valor1 + valor2);
            } else if (operacao == "DIV")
            {
                textBox1.Text = Convert.ToString(valor1 / valor2);
            } else if (operacao == "MULTI")
            {
                textBox1.Text = Convert.ToString(valor1 * valor2);
            } else
            {
                textBox1.Text = Convert.ToString(valor1 - valor2);
            };
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
