using CursoDesignPatterns.Contollers;
using CursoDesignPatterns.Modelos.Desconto;
using CursoDesignPatterns.Modelos.Impostos;
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

            // STRATEGY
            Imposto iss = new ISS("ISS");
            Imposto icms = new ICMS("ICMS");

            // DECORATOR
            Imposto ippt = new IPPT("IPPT", new ICCC("ICCC"));

            // TEMPLATE METHOD
            Imposto ikcv = new IKCV("IKCV");
            Imposto iqcc = new IQCC("IQCC");

            CalculadoraDeImpostos calculadoraDeImpostos = new CalculadoraDeImpostos();
            calculadoraDeImpostos.RealizaCalculo(orcamento, iss);
            calculadoraDeImpostos.RealizaCalculo(orcamento, icms);
            calculadoraDeImpostos.RealizaCalculo(orcamento, ippt);
            calculadoraDeImpostos.RealizaCalculo(orcamento, ikcv);
            calculadoraDeImpostos.RealizaCalculo(orcamento, iqcc);

            CalculadoraDeDescontos calculadoraDeDescontos = new CalculadoraDeDescontos();
            calculadoraDeDescontos.RealizaCalculo(orcamento);

            Console.ReadKey();
        }
    }
}
