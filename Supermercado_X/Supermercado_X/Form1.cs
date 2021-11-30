using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Supermercado_X
{
    public partial class Form1 : Form
    {
        public string foto = "";
       public Form1()
        {
            InitializeComponent();

        }
       
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = null;
            txtPrCusto.Text = null;
            txtProd.Text = null;
            txtVenda.Text = null;
            pictureBox1.Image = null;

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Produto objproduto = new Produto();
            objproduto.Codigo = Convert.ToInt32(txtCodigo.Text);
            objproduto.Nome = txtProd.Text;
            objproduto.Custo = Convert.ToDouble(txtPrCusto.Text);
            objproduto.Venda = Convert.ToDouble(txtVenda.Text);

            MessageBox.Show(objproduto.VerificaValor(), "Mensagem");

            txtCodigo.Text = null;
            txtPrCusto.Text = null;
            txtProd.Text = null;
            txtVenda.Text = null;
            pictureBox1.Image = null;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog novo = new OpenFileDialog();
            novo.ShowDialog();
            if (novo.FileName != "")
            {
                this.foto = novo.FileName;
                pictureBox1.Load(this.foto);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
