using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_MuitosImpostos
{
    public class InvestimentoConservador
         : IInvestimento
    {
        /// <summary>
        /// Método implementado pelo professor.
        /// </summary>
        /// <param name="conta"></param>
        /// <returns></returns>
        public double Calcula(ContaBancaria conta)
        {
            return (double)conta.Saldo * 0.0008;
        }

        /// <summary>
        /// Método implementado por mim.
        /// </summary>
        /// <param name="saldo"></param>
        /// <returns></returns>
        public decimal InvestirSaldo(decimal saldo)
        {
            return saldo * 0.08m;
        }
    }
}
