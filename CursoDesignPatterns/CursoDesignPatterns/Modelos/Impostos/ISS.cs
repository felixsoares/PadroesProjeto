using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ISS : Imposto
    {
        public string Nome { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        public ISS(string nome)
        {
            this.Nome = nome;
        }
    }
}
