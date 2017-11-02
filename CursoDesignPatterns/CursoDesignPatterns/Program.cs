using CursoDesignPatterns.Contollers;
using CursoDesignPatterns.Modelos.Desconto;
using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento();
            orcamento.AdicionaItem(new Item("Relogio", 200.0));
            orcamento.AdicionaItem(new Item("Camiseta", 80.0));
            orcamento.AdicionaItem(new Item("Cinto", 20.0));
            orcamento.AdicionaItem(new Item("Outros", 200.0));

            Console.WriteLine("Valor do Orçamento: " + orcamento.Valor);

            Imposto iss = new ISS("ISS");
            Imposto icms = new ICMS("ICMS");
            Imposto icc = new ICCC("ICCC");

            CalculadoraDeImpostos calculadoraDeImpostos = new CalculadoraDeImpostos();
            calculadoraDeImpostos.RealizaCalculo(orcamento, iss);
            calculadoraDeImpostos.RealizaCalculo(orcamento, icms);
            calculadoraDeImpostos.RealizaCalculo(orcamento, icc);

            CalculadoraDeDescontos calculadoraDeDescontos = new CalculadoraDeDescontos();
            calculadoraDeDescontos.RealizaCalculo(orcamento);

            Console.ReadKey();
        }
    }
}
