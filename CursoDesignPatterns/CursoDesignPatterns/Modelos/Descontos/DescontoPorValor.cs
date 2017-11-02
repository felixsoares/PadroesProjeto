using CursoDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class DescontoPorValor : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if(orcamento.Valor > 700.0)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}
