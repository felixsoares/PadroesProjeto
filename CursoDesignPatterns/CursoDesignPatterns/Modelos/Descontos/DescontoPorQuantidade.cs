using CursoDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class DescontoPorQuantidade : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if(orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.01;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}
