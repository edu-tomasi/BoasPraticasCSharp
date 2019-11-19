using System;
using System.Collections.Generic;
using System.Text;

namespace PatternDecorator_ImpostosCompostos
{
    /// <summary>
    /// Classe especializada em calcular o Imposto de ISS.
    /// </summary>
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto) { }
        public ISS() { }

        /// <summary>
        /// Implementação da regra de negócio para calcular o imposto.
        /// </summary>
        /// <param name="orcamento"></param>
        /// <returns></returns>
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }
    }
}
