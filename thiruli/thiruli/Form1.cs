using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thiruli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario, qtdeqlwt, vlQlwt, vlresidencia, vldesc, vlcomdesc;
            
            try
            {
                salario = Convert.ToDouble(textBox1.Text);
                 qtdeqlwt = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Digite Apenas Numeros.");return;
                
            }

            vlQlwt = (salario / 7) / 100;
            textBox3.Text= vlQlwt.ToString("###.00"); 



            vlresidencia = qtdeqlwt * vlQlwt;
            textBox4.Text = vlresidencia.ToString("###.00");

            vldesc = vlresidencia * 0.10;
            vlcomdesc = vlresidencia - vldesc;
            textBox5.Text = vlcomdesc.ToString("###0.00"); ;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }
    }
}
