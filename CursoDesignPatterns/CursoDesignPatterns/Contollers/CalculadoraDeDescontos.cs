using CursoDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Contollers
{
    class CalculadoraDeDescontos
    {
        public void RealizaCalculo(Orcamento orcamento)
        {
            // CHAIN OF RESPONSIBILITY
            Desconto d1 = new DescontoPorQuantidade();
            Desconto d2 = new DescontoPorValor();
            Desconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            double valor = d1.Desconta(orcamento);
            Console.WriteLine("Desconto de: " + valor);
        }
    }
}
