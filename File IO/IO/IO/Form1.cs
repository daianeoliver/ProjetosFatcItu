using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void alterarFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void alterarCorDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void alterarCorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
           
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            txtEdit.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.Write(txtEdit.Text);
            sw.Close();
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                txtEdit.ForeColor = colorDialog1.Color;
            }
        }

        private void fundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                txtEdit.BackColor = colorDialog1.Color;
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                txtEdit.Font = fontDialog1.Font;
            }
        }
    }
}
