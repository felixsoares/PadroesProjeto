using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public abstract class Imposto
    {
        public string Nome { get; set; }

        // DECORATOR
        public Imposto OutroImposto { get; set; }

        // DECORATOR
        public Imposto(string nome, Imposto imposto)
        {
            this.Nome = nome;
            this.OutroImposto = imposto;
        }

        public Imposto(string nome)
        {
            this.Nome = nome;
        }
        
        public abstract double Calcula(Orcamento orcamento);

        // DECORATOR
        protected double CalculaOutroImposto(Orcamento orcamento)
        {
            if(OutroImposto != null)
            {
                return OutroImposto.Calcula(orcamento);
            }

            return 0;
        }
    }
}
