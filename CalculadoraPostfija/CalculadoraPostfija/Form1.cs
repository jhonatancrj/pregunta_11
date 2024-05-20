using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPostfija
{
    public partial class Form1 : Form
    {
        private CalculadoraPostfija calculadora;

        public Form1()
        {
            InitializeComponent();
            calculadora = new CalculadoraPostfija();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string expresion = textBox1.Text;
                double resultado = calculadora.EvaluarPostfija(expresion);
                textBox2.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
