using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Critter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdName_Click(object sender, EventArgs e)
        {
          label1.Text =  txtName.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboMood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMood.SelectedIndex == 0)
                picCritter.Image = picHappy.Image;
                else if (cboMood.SelectedIndex == 1)
                    picCritter.Image = picIndiff.Image;
                    else 
                        picCritter.Image = picMed.Image;
        }

        private void picCritter_Click(object sender, EventArgs e)
        {

        }

        private void scrSize_Scroll(object sender, ScrollEventArgs e)
        {
            picCritter.Size = new Size(scrSize.Value, scrSize.Value);
        }
    }
}
