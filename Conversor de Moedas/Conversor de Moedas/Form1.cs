using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Moedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double VL_REAL, vl_Convertido;

            VL_REAL = Convert.ToDouble(textBox1.Text);
            

            if (rdbDolar.Checked)
            {
                vl_Convertido = VL_REAL * 0.32233;
                textBox2.Text = Convert.ToString(vl_Convertido);
            }
            if (rdbLibra.Checked)
            {
                vl_Convertido = VL_REAL * 0.24476;
                textBox2.Text = Convert.ToString(vl_Convertido);                        
            }
            if (rdbEuro.Checked) 
                    {
                vl_Convertido = VL_REAL * 0.26962;
                textBox2.Text = Convert.ToString(vl_Convertido);
            }

           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
