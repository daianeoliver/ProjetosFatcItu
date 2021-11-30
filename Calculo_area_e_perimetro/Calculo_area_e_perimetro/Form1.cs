using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_area_e_perimetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Base, Altura, Area, Perimetro;
            Base = Convert.ToDouble(textBox1.Text);
            Altura = Convert.ToDouble(textBox2.Text);
            //Area = Convert.ToDouble(textBox3.Text);
            //Perimetro = Convert.ToDouble(textBox4.Text);

            Area = Base * Altura;
            Perimetro = 2 * (Base + Altura);

            textBox3.Text = Convert.ToString(Area);
            textBox4.Text = Convert.ToString(Perimetro);



        }
    }
}
