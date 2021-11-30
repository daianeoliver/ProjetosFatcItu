using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta_de_Telefone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int Num_Tel, Tipo_Tel, Qtde_Pulso, Qtde_Inter, Qtde_Desp;
            Double Valor_Conta;

            Num_Tel = Convert.ToInt32(textBox1.Text);
            Tipo_Tel = Convert.ToInt32(textBox2.Text);
            Qtde_Pulso = Convert.ToInt32(textBox3.Text);
            Qtde_Inter = Convert.ToInt32(textBox4.Text);
            Qtde_Desp = Convert.ToInt32(textBox5.Text);

            if (textBox2.Text == "1")
            {
                textBox6.Text = Convert.ToString(Valor_Conta = 10);
                MessageBox.Show("True");
            }
            else
            {
                textBox6.Text = Convert.ToString(Valor_Conta = 15);
                MessageBox.Show("false");
            }
            
            if (Qtde_Pulso> 90)
            {
                Valor_Conta = Valor_Conta + (Qtde_Pulso - 90)*0.05;
                Valor_Conta = Valor_Conta + (Qtde_Inter * 60) * 0.08;
                Valor_Conta = Valor_Conta + (Qtde_Desp * 2);

                textBox6.Text = Convert.ToString(Valor_Conta);
                MessageBox.Show("True");
            }
            else
            {
                textBox6.Text = Convert.ToString(Valor_Conta);
                MessageBox.Show("false");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
