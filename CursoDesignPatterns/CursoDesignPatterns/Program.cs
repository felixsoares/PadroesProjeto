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

            Console.WriteLine("Valor inicial do Orçamento: " + orcamento.Valor);

            // STATE
            orcamento.AplicaDescontoExtra();
            Console.WriteLine("Valor do Orçamento (desconto extra): " + orcamento.Valor);

            // STATE
            orcamento.Aprova();

            // STATE
            orcamento.AplicaDescontoExtra();
            Console.WriteLine("Valor do Orçamento (desconto extra): " + orcamento.Valor);

            // STATE
            orcamento.Finaliza();

            try
            {
                // STATE
                orcamento.AplicaDescontoExtra();
                Console.WriteLine("Valor do Orçamento (desconto extra): " + orcamento.Valor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

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

            // CHAIN OF RESPONSIBILITY
            CalculadoraDeDescontos calculadoraDeDescontos = new CalculadoraDeDescontos();
            calculadoraDeDescontos.RealizaCalculo(orcamento);

            Console.ReadKey();
        }
    }
}
