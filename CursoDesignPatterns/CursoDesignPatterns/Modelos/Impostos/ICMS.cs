using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICMS : Imposto
    {
        public string Nome { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        public ICMS(string nome)
        {
            this.Nome = nome;
        }
    }
}
