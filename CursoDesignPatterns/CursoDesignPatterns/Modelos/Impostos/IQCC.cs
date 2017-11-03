using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modelos.Impostos
{
    // TEMPLATE METHOD
    class IQCC : TemplateDeImpostoCondicional
    {
        public IQCC(string nome) : base(nome)
        {

        }

        public override bool DeveUsarImposto(Orcamento orcamento)
        {
            return orcamento.Valor > 1230;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.12;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
