using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICMS : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculaOutroImposto(orcamento);
        }

        public ICMS(string nome) : base (nome)
        {

        }

        public ICMS(string nome, Imposto imposto) : base(nome, imposto)
        {

        }
    }
}
