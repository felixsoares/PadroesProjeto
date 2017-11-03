using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modelos.Impostos
{
    // TEMPLATE METHOD
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarImposto(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        public abstract double MinimaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract bool DeveUsarImposto(Orcamento orcamento);

        public TemplateDeImpostoCondicional(string nome) : base(nome)
        {

        }
    }
}
