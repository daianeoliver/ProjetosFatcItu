using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuaba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int i, numero, total;
            string aux;

            numero = Convert.ToInt32(txtNumero.Text);

            //Ordem Crescente
            for (i = 1; i <= 10; i = i + 1) 
            {
                total = i * numero;
                aux = string.Format("{0:00} x {1:00} = {2:000} \n", i, numero, total);
                lblCrescente.Text = lblCrescente.Text + aux;
            }

            //Ordem Decrescente
            for (i = 10; i >= 1; i = i - 1) 
            {
                total = i * numero;
                aux = string.Format("{0:00} x {1:00} = {2:000} \n", i, numero, total);
                lblDecrescente.Text = lblDecrescente.Text + aux;
            }

        }
    }
}
