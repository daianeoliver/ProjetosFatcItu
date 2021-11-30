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
    public partial class frmAbertura : Form
    {
        public static string senha;
        public static string usuario;
        public frmAbertura()
        {
            InitializeComponent();
        }
        private void frmAbertura_Load(object sender, EventArgs e)
        {

        }
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "123")
            {
                frmMenu objform_menu = new frmMenu();
                usuario = txtUsuario.Text;
                this.Close();
            }
            else
                MessageBox.Show("Senha Inválida", "Cuidado:");
        }
    }
}
