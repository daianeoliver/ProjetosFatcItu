using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animação
{
    public partial class Form1 : Form
    {
        int counter = 0; //fora dos métodos, mas dentro da classe
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter >=4 )//qtde de figuras
            {
                counter = 0;
            }
            pictureBox1.Image = myPics.Images[counter];//troca a figura
        }
    }
}
