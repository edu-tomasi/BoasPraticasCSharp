using System;
using System.Collections.Generic;
using System.Text;

namespace PatternStrategy_MuitosImpostos
{
    /// <summary>
    /// Classe especializada em calcular o Imposto de ISS.
    /// </summary>
    public class ISS : IImposto
    {
        /// <summary>
        /// Implementação da regra de negócio para calcular o imposto.
        /// </summary>
        /// <param name="orcamento"></param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
