using System;
using System.Collections.Generic;
using System.Text;

namespace PatternDecorator_ImpostosCompostos
{
    /// <summary>
    /// Classe especializada em calcular o Imposto de ICMS.
    /// </summary>
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto) { }
        public ICMS() { }

        /// <summary>
        /// Implementação da regra de negócio para calcular o imposto.
        /// </summary>
        /// <param name="orcamento"></param>
        /// <returns></returns>
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }
    }
}
