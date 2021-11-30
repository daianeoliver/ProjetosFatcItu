using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            int num;
            num = Convert.ToInt32(textBox1.Text);
            if (num == 1)
            {
                Form2 novaforma = new Form2();
                novaforma.Show();

            }
            else
                MessageBox.Show("Número de conta inválido!");



        }
    }
}
