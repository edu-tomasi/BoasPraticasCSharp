using System;
using System.Collections.Generic;
using System.Text;

namespace MuitosImpostos_StrategyPattern
{
    /// <summary>
    /// Classe especializada em calcular o Imposto de ISS.
    /// </summary>
    public class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
