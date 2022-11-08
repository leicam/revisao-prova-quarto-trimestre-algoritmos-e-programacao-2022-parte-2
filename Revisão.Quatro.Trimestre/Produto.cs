using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão.Quatro.Trimestre
{
    public class Produto
    {
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public int EAN { get; private set; }

        //encapsulamento
        public Produto(string descricao,
            decimal preco, int ean)
        {
            Descricao = descricao;
            Preco = preco;
            EAN = ean;
        }

        //override sobre escrita de um método
        //polimorfismo
        public override string ToString()
        {
            return EAN + " " + Descricao + " " + Preco;
        }
    }
}