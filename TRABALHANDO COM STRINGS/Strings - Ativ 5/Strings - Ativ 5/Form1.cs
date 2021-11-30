using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings___Ativ_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string saida, stringOriginal, string1, string2, string3, string4;
            char[] VetorDeCaracter = { 'a', 'e', 'i', 'o', 'u', ' ', 'A', 'B', 'C' };
            stringOriginal = "Bem vindo ao Curso de C#";
            string1 = stringOriginal;
            string2 = new string(VetorDeCaracter);
            string3 = new string(VetorDeCaracter, 6, 3);
            string4 = new string('C', 5);
            saida = "string1 =" + "\"" + string1 + "\"\n" +
            "string2 =" + "\"" + string2 + "\"\n" +
            "string3 =" + "\"" + string3 + "\"\n" +
            "string4 =" + "\"" + string4 + "\"";
            MessageBox.Show(saida, "Construtores de string", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
