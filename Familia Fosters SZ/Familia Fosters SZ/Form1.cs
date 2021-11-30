using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Familia_Fosters_SZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, soma;
            a = System.Convert.ToInt32(TextBox1.Text);
            b = System.Convert.ToInt32(TextBox2.Text);
            soma = a + b;
            MessageBox.Show("A Soma é = " + soma.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
