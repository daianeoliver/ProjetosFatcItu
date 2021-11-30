using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_6___button___Ativ_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string texto;
            texto = textBox1.Text;
            for (int i =0; i<texto.Length;i++)
            {
                if (texto[i]=='a' || texto[i] == 'A' || texto[i] == 'e' || texto[i] == 'E' || texto[i] == 'i' || texto[i] == 'I' || texto[i] == 'o' || texto[i] == 'O' || texto[i] == 'u' || texto[i] == 'U')
                {
                    contador++;
                    MessageBox.Show("A frase tem: "+ contador + " vogais.");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string frase, saida;

            frase = textBox2.Text;

            saida = "Frase: " + frase + "\n";
            saida += "\n A frase invertida é: ";
            for (int i = frase.Length - 1; i >= 0; i--)
                saida += frase[i];

            MessageBox.Show(saida);
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tx= textBox3.Text;
            tx = tx.Replace(" ", "*");
            MessageBox.Show(tx);
        
                
        }


    }
}

