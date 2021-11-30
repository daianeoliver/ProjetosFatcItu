using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerador_Denominador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            try
            {
                int numerador = Convert.ToInt32(textBox1.Text);
                int denominador = Convert.ToInt32(textBox2.Text);
                int resultado = numerador / denominador;
                textBox3.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Você deve informar dois inteiros!", "Formato de número inválido", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Você não pode dividir por zero", "Divisão inválida", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
