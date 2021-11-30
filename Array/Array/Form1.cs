using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class frmContador : Form
    {
        private int counter; //índice do vetor
        private string[] numbers = new String[5]; //aloca posições de memória para uma vetor
        public frmContador()
        {
            InitializeComponent();
            
            numbers[0] = "ZERO"; //inicialização do vetor
            numbers[1] = "UM";
            numbers[2] = "DOIS";
            numbers[3] = "TRÊS";
            numbers[4] = "QUATRO";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                lblOutput.Text = numbers[counter];
                
            }
            catch
            {
                MessageBox.Show("Fim de método!");
            }

            counter++;
        }
    }
}
