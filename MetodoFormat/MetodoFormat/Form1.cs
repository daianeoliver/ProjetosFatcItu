using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoFormat
{
    public partial class frmExemplo2 : Form
    {
        public frmExemplo2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, total;
            string msg;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            total = num1 * num2;

            msg = string.Format("{0:###,##0.00} x {1:###,##0.00} = {2:###,##0.00}", num1, num2, total);

            MessageBox.Show(msg);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
        }
    }
}
