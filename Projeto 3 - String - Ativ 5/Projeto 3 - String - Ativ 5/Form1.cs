using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_3___String___Ativ_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sPalavra = "";
            for (int cont = 1; cont <= numVezes.Value; cont++)
            {
                sPalavra = sPalavra + txtFrase.Text +"\n";
            }
            MessageBox.Show(sPalavra+"O total de caracteres é:"+sPalavra.Length);
        }

        private void numVezes_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
