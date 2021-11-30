using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizador_de_imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //** default to JPEG images
            this.radJPEG.Checked = false;
            this.radBMP.Checked = false;

            //** preset folder browser control to desktop, and configure other options...
            this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            this.folderBrowserDialog1.Description = "Please locate folder containing pictures to view...";

            //** inicializa o relógio na barra de status
            this.SbarClockLabel.Text =
            System.DateTime.Now.ToString("hh:mm tt, MM-dd-yyyy");
            //** atualiza o tempo a cada 30s
            this.timer1.Interval = 30000;
            this.timer1.Enabled = true;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            //** Show dialog to user, which doesn't return until user clicks OK / Cancel...
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder, pattern, pathname, filename;
                //** get user's selection
                folder = this.folderBrowserDialog1.SelectedPath;

                
                //** what type of files to read from folder? .jpg, .bmp, ?
                if (this.radJPEG.Checked == true)
                
                    pattern = ".jpg";
                
                else if (this.radBMP.Checked == true)
                
                    pattern = ".bmp";
                

                else

                    pattern = ".";
                Globals.CurrentPictureFolder = folder;
                this.SbarFolderLabel.Text = folder;
                //** now read contents of folder based on pattern...
                string[] files = null;
                files = System.IO.Directory.GetFiles(folder, pattern);
                //** finally, clear list box and load new list of files!
                this.lstFileNames.Items.Clear();
                foreach (string pathname_loopVariable in files)
                {
                    pathname = pathname_loopVariable;
                    filename = System.IO.Path.GetFileName(pathname);
                    this.lstFileNames.Items.Add(filename);
                }

                
               
                
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void lstFileNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                string filename = null;
                string folder = null;
                string pathname = null;
                filename = this.lstFileNames.SelectedItem.ToString();
                folder = Globals.CurrentPictureFolder;
                pathname = System.IO.Path.Combine(folder, filename);
                this.picImage.Image = System.Drawing.Image.FromFile(pathname);                  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                //** atualiza o relógio na barra de status...
                this.SbarClockLabel.Text = System.DateTime.Now.ToString("hh:mm tt, MM-dd-yyyy");
            }
        }
    }
}
