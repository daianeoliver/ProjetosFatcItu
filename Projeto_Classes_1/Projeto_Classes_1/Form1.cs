using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Classes_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Pessoa objpessoa = new Pessoa();
            objpessoa.Idade = Convert.ToInt32(textBox2.Text);
            objpessoa.Nome = textBox1.Text;
            MessageBox.Show(objpessoa.VerificarIdade(), "Mensagem de Orientação");
        }
    }
}
