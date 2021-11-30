using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palindromo, saida;
            char[] arrayDeCaracteres;
            arrayDeCaracteres = new char[5];
            palindromo = "socorram-me subi no onibus em marrocos";
            saida = "String1: " + palindromo + "\n";
            saida += "\nTamanho da string1:" + palindromo.Length;
            saida += "\nA string invertida é: ";
            for (int i = palindromo.Length - 1; i >= 0; i--)
                saida += palindromo[i];
            palindromo.CopyTo(0, arrayDeCaracteres, 0, 5);
            saida += "\nO vetor de caracteres:";
            for (int i = 0; i < arrayDeCaracteres.Length; i++)
                saida += arrayDeCaracteres[i];
            MessageBox.Show(saida, "Demonstração de manipulação de strings" +
            "Indexadores,Tamanho e Copia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
