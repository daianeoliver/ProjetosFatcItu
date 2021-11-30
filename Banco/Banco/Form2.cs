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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //new: aloca memória suficinete para guardar todas as informações da conta;
            //variáveis: 1, Daiane e 10000;
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "Daiane";
            c.saldo = 1000.0;

            


            textBox1.Text = Convert.ToString(c.numero);
            textBox2.Text = Convert.ToString(c.titular);
            textBox3.Text = Convert.ToString(c.saldo);


        }
       
    }
}


