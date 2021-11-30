using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Linguagens
{
    public partial class Form1 : Form
    {
        string[] languages = {
                                "Java",
                                "Perl",
                                "Pascal",
                                "Pyton",
                                "C#"
                                }; //outra maneira de se criar um vetor
        string[] sortedLangs = new string[5]; //vetor ordenado
        private void showUnsorted() //método criado pelo usuário
        {
            //este método carrega o vetor na listbox
            lstOutput.Items.Clear(); //limpa a listbox
            lstOutput.Items.AddRange(languages); //carrega o vetor acima na listbox
        }
            public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void optUnsorted_CheckedChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            txtSearch.Enabled = false;
            showUnsorted();
        }

        private void optSorted_CheckedChanged(object sender, EventArgs e)
        {
            languages.CopyTo(sortedLangs, 0); //copia os elementos de um para outro
            Array.Sort(sortedLangs); //ordena um vetor
            btnSearch.Enabled = true;
            txtSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int theIndex;
            string message;
            theIndex = Array.BinarySearch(sortedLangs, 0, sortedLangs.Length, txtSearch.Text);
            if (theIndex < 0)
            {
                message = "Não encontrado";
            }
            else
            {
                message = sortedLangs[theIndex];
                message += " está na posição ";
                message += theIndex.ToString();
            }
            MessageBox.Show(message);
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            foreach (string theLang in languages)
            {
                MessageBox.Show(theLang);
            }
        }
    }
}
