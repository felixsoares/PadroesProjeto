using CursoDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class SemDesconto : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
