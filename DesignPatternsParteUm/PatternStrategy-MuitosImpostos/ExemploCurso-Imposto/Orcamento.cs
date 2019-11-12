using System;
using System.Collections.Generic;
using System.Text;

namespace PatternStrategy_MuitosImpostos
{
    /// <summary>
    /// Representação do Orçamento.
    /// </summary>
    public class Orcamento
    {
        public double Valor { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
        }
    }
}
