using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_1
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

        private void btnSomatoria_Click(object sender, EventArgs e)
        {
            int Resultado = 0;
            int Qtde;
            int x;
            Qtde = Convert.ToInt32(txtnumero.Text);
            for (x = 0; x <= Qtde;x++)
            {
                Resultado += x;
            
            }
            MessageBox.Show(String.Format("O resultado é {0:00}", Resultado));
        }

        private void btnImpares_Click(object sender, EventArgs e)
        {
            int Resultado = 0;
            int Qtde;
            int x;
            Qtde = Convert.ToInt32(txtnumero.Text);
            for (x = 0; x <= Qtde; x++)
            {
                if ((x % 2) != 0) ;
                Resultado += x;

            }
            MessageBox.Show(String.Format("O resultado é {0:00}", Resultado));
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            
            int Qtde;
            int n;
            double fatorial;
            Qtde = Convert.ToInt32(txtnumero.Text);
            for (n = 1, fatorial = 1;n <= Qtde; n++)
            {
                fatorial = fatorial * n;

            }
            MessageBox.Show(String.Format("O resultado é {00:00}", fatorial));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
