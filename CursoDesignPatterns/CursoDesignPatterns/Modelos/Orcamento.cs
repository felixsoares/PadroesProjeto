using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.Modelos.Desconto;
using CursoDesignPatterns.Modelos.Descontos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public EstadoOrcamento EstadoAtual { get; set; }
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento()
        {
            this.Valor = 0.0;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            this.Valor += item.Valor;
            Itens.Add(item);
        }

        // STATE
        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        // STATE
        public void Aprova()
        {
            EstadoAtual.Aprova(this);
            Console.WriteLine("Estado atual: " + EstadoAtual.Descricao);
        }

        // STATE
        public void Reprova()
        {
            EstadoAtual.Reprova(this);
            Console.WriteLine("Estado atual: " + EstadoAtual.Descricao);
        }

        // STATE
        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
            Console.WriteLine("Estado atual: " + EstadoAtual.Descricao);
        }
    }
}
