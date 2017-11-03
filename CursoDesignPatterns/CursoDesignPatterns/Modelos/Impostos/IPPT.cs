using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modelos.Impostos
{
    public class IPPT : Imposto
    {
        public IPPT(string nome) : base(nome)
        {

        }

        public IPPT(string nome, Imposto imposto) : base(nome, imposto)
        {

        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.7 + CalculaOutroImposto(orcamento);
        }
    }
}
