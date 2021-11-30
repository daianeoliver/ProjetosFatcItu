using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Font_Chooser
{
   

    public partial class myForm : Form
    {
        private System.Drawing.Font myFont;
        private string fontName = "Arial";
        private int fontSize = 20;
        private FontStyle myStyle = FontStyle.Regular;
        public myForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssignFont();
        }
        private void AssignFont()
        {
            fontName = listBox1.Text;
            myStyle = FontStyle.Regular;
            if (chkBold.Checked)
            {
                myStyle = myStyle | FontStyle.Bold;
            }
            if (chkItalic.Checked)
            {
                myStyle = myStyle | FontStyle.Italic;
            }
            myFont = new Font(fontName, fontSize, myStyle);
            lblOutput.Font = myFont;
        }
        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void rad10_CheckedChanged(object sender, EventArgs e)
        {
            fontSize = 10;
            AssignFont();
        }

        private void rad20_CheckedChanged(object sender, EventArgs e)
        {
            fontSize = 20;
            AssignFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            AssignFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            fontSize = 10;
            AssignFont();
        }
    }
}
