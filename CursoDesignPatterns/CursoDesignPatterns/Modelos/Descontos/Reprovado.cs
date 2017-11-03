using CursoDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modelos.Descontos
{
    public class Reprovado : EstadoOrcamento
    {
        public string Descricao { get; set; }

        public Reprovado()
        {
            this.Descricao = "Reprovado";
        }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Não poderá receber desconto em estado Reprovado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já foi reprovado previamente");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está reprovado");
        }
    }
}
