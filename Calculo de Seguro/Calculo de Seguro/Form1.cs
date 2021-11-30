using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_Seguro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;
            //MessageBox.Show("Item selecionado: " + selectedItem.ToString() + "\n" +
               // "Indice: " + selectedIndex.ToString());
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double VL_Car, Desc_sex,Id, Desc_id, Desc_Per, Total;
            Id = comboBox1.SelectedIndex;

            VL_Car = Convert.ToDouble(textBox2.Text);

            VL_Car = VL_Car * 0.10;
            textBox3.Text = Convert.ToString(VL_Car);

            if (rdbFem.Checked)
            {
                Desc_sex = VL_Car * 0.075;
                textBox4.Text = Convert.ToString(Desc_sex);
            }
            else
            {
                Desc_sex = VL_Car * 0.050;
                textBox4.Text = Convert.ToString(Desc_sex);

            }
            if (checkBox1.Checked)
            {
                Desc_Per = VL_Car * 0.015;
                textBox6.Text = Convert.ToString(Desc_Per);
            }
            else
            {
                Desc_Per = VL_Car * 0.018;
                textBox6.Text = Convert.ToString(Desc_Per);
            }
            MessageBox.Show("mostre:"+Id);

            if (Id == 0)
            {
                Desc_id = VL_Car * 0.015;
                textBox5.Text = Convert.ToString(Desc_id);
            }
            else 
                if (Id == 1)
                {
                    Desc_id = VL_Car * 0.025;
                    textBox5.Text = Convert.ToString(Desc_id);
                }
                else 
                {
                    Desc_id = VL_Car * 0.037;
                    textBox5.Text = Convert.ToString(Desc_id);
                }

           Total = VL_Car -( Desc_sex + Desc_Per + Desc_id);
            textBox7.Text = Convert.ToString(Total);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            comboBox1.Text = " ";
           

        }
    }
}
