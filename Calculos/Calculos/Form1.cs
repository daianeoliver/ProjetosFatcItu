using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos
{
    public partial class frmExemplo1 : Form
    {
        public frmExemplo1()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double num1, num2, total;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            total = num1 * num2;

            lblResultado.Text = Convert.ToString(total);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResultado.Text = "";
        }
    }
}
