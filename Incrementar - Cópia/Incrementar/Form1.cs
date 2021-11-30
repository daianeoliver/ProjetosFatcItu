using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incrementar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Random  randomNumber = new Random();
        int total;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rollButton_Click(object sender, System.EventArgs e)
        {
            total = 0;
            DisplayDie(dieLabel1);
            DisplayDie(dieLabel2);
            DisplayDie(dieLabel3);
            DisplayDie(dieLabel4);
            if ((total % 2) == 0)
            {
                MessageBox.Show("Você é um cara de sorte!");

            }
        }
        public void DisplayDie(PictureBox dieLabel)
        {
            int face = randomNumber.Next(1, 7);
            dieLabel.Image = Image.FromFile("c:\\intel\\die" + face + ".gif");
            total = total + face;
            MessageBox.Show(" " + total);
  
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
