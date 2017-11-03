using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ISS : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculaOutroImposto(orcamento);
        }

        public ISS(string nome) : base(nome)
        {

        }

        public ISS(string nome, Imposto imposto) : base(nome, imposto)
        {

        }
    }
}
