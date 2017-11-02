using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public interface Imposto
    {
        string Nome { get; set; }
        double Calcula(Orcamento orcamento);
    }
}
