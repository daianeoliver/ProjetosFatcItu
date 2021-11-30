using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_6___String___Ativ_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, qtd;
            string aux;


            aux = txtFrase.Text;
            aux = aux.ToUpper();

            for (i = 0, qtd = 0; i < aux.Length; i++)
                if (aux.Substring(i, 1) == txtLetra.Text.ToUpper())
                    qtd++;
            MessageBox.Show("a letra aparece" + Convert.ToString(qtd) + "vezes.");
        }
    }
}
