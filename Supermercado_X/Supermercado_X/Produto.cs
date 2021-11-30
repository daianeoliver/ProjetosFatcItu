using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado_X
{
    class Produto
    {
        private string _nome;
        private int _codigo;
        private double _custo;
        private double _venda;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }

        }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public double Custo
        {
            get { return _custo; }
            set { _custo = value; }
        }

        public double Venda
        {
            get { return _venda; }
            set { _venda = value; }
        }

        public string VerificaValor()
        {
            string msg;
            if (_venda < _custo)
            {
                msg = "Valor de Venda não pode ser menor que valor de custo!";
            }
            else
            {
                msg = "Produto cadastrado com sucesso!";
            }
            return msg;
        }
     

      
        
                
    }
}



    