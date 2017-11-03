using CursoDesignPatterns.Modelos.Desconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modelos.Impostos
{
    // TEMPLATE METHOD
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(string nome) : base(nome)
        {

        }

        public override bool DeveUsarImposto(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && VerificaValorDosItens(orcamento);
        }

        private bool VerificaValorDosItens(Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }

            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
