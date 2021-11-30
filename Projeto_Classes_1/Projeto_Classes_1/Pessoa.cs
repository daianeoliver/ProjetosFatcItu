using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Classes_1
{
    class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value > 120 || value < 0)
                    _idade = 0;
                else _idade = value;
            }
        }
        public string VerificarIdade()
        {
            string msg;
            if (Idade > 18)
                msg = "Acesso liberado";
            else
                msg = "Acesso proibido";
            return msg;


        }

    }
}     

