using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Interfaces
{
    public interface Desconto
    {
        Desconto Proximo { get; set; }
        double Desconta(Orcamento orcamento);
    }
}
