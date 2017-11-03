using CursoDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modelos.Descontos
{
    class Finalizado : EstadoOrcamento
    {
        public string Descricao { get; set; }

        public Finalizado()
        {
            this.Descricao = "Finalizado";
        }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Não poderá receber desconto em estado Finalizado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi finalizado");
        }
    }
}
