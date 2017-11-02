using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class CalculadoraDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            // STRATEGY
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine("Imposto: " + imposto.Nome + " Valor: " + valor);
        }
    }
}
