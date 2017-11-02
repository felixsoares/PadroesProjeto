using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    class ICCC : Imposto
    {
        public string Nome { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            double valor = 0.0;

            if(orcamento.Valor < 1000.0)
            {
                valor = orcamento.Valor * 0.05;
            }
            else if(orcamento.Valor >= 1000.0 && orcamento.Valor <= 3000.0)
            {
                valor = orcamento.Valor * 0.07;
            }
            else
            {
                valor = (orcamento.Valor * 0.08) + 30.0;
            }

            return valor;
        }

        public ICCC(string nome)
        {
            this.Nome = nome;
        }
    }
}
