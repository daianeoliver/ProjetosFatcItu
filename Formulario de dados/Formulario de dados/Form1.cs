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
    public partial class frmMenu : Form
    {
        private void frmMenu_Load(object sender, EventArgs e)
        {
            frmAbertura objform_abertura = new frmAbertura();
            objform_abertura.ShowDialog();
        }
        private void cadastroDeInformaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntrada objform_entrada = new frmEntrada();
            objform_entrada.MdiParent = this;
            objform_entrada.Show();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}