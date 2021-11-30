using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class frmExemplo02 : Form
    {
        public frmExemplo02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radVermelho_CheckedChanged(object sender, EventArgs e)
        {
            lblVermelho.Visible = true;
            lblAmarelo.Visible = false;
            lblVerde.Visible = false;
        }

        private void radAmarelo_CheckedChanged(object sender, EventArgs e)
        {
            lblVermelho.Visible = false;
            lblAmarelo.Visible = true;
            lblVerde.Visible = false;
        }

        private void radVerde_CheckedChanged(object sender, EventArgs e)
        {
            lblVermelho.Visible = false;
            lblAmarelo.Visible = false;
            lblVerde.Visible = true;
        }
    }
}
