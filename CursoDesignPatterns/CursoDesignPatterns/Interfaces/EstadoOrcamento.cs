using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Interfaces
{
    public interface EstadoOrcamento
    {
        string Descricao { get; set; }

        void AplicaDescontoExtra(Orcamento orcamento);

        void Aprova(Orcamento orcamento);

        void Reprova(Orcamento orcamento);

        void Finaliza(Orcamento orcamento);
    }
}
