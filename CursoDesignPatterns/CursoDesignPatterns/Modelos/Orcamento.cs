using CursoDesignPatterns.Modelos.Desconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento()
        {
            this.Valor = 0.0;
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            this.Valor += item.Valor;
            Itens.Add(item);
        }
    }
}
