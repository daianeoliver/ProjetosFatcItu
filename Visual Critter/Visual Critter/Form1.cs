using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Critter
{
    public partial class SrcSize : Form
    {
        public SrcSize()
        {
            InitializeComponent();
        }

       
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Size = new Size(vScrollBar1.Value, vScrollBar1.Value);
        }
    }
}
