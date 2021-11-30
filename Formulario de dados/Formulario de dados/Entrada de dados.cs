using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_de_dados
{
    public partial class frmEntrada : Form
    {
        public frmEntrada()
        {
            InitializeComponent();
            txtUsuario.Text = frmAbertura.usuario;
        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmAbertura.usuario == "ADM")
            {
                frmAbertura.usuario = "BIB";
                MessageBox.Show("Acessamos e trocamos os dados do usuário em outra classe",
                frmAbertura.usuario);
                txtUsuario.Text = frmAbertura.usuario;
            }
        }
    }
}
