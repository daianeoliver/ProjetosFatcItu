using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aprimeirafacegraficadadaiane
{
    public partial class frmExemplo : Form
    {
        public frmExemplo()
        {
            InitializeComponent();
        }

        private void daiane_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtinformacao.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtinformacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
