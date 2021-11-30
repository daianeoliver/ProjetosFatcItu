using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Festa_Fatec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int vl1=0, vl2=0, vl3=0, vl4=0, total, ac=0;
            
            vl1 = Convert.ToInt32(numericUpDown1.Value);
            vl2 = Convert.ToInt32(numericUpDown2.Value);
            vl3 = Convert.ToInt32(numericUpDown3.Value);
            vl4 = Convert.ToInt32(numericUpDown4.Value);

            total = vl1 * 5 + vl2 * 5 + vl3 * 5 + vl4 * 10;
            
            textBox2.Text = Convert.ToString(total);
            
            ac = ac + total;
            textBox1.Text = Convert.ToString(ac);
            
       
        
        }
        
        private void btnEncerramento_Click(object sender, EventArgs e)
        {
            
            StreamWriter sw = new StreamWriter("c:\\alunos\\encerramento.txt");
            sw.Write("total: " + textBox2.Text);
            sw.Write(" Operador: " + comboBox1.Text);
            sw.Close();

            MessageBox.Show("Caixa Fechado!");    
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            textBox2.Text = "";
            textBox1.Text = "";
            comboBox1.Text = "";



        }
    }
}
