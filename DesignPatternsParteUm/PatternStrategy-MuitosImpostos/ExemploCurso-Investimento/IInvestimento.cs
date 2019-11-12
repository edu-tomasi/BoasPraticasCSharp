using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_MuitosImpostos
{
    public interface IInvestimento
    {
        /// <summary>
        /// Método que eu criei.
        /// </summary>
        /// <param name="saldo"></param>
        /// <returns></returns>
        decimal InvestirSaldo(decimal saldo);

        /// <summary>
        /// Método apresentado pelo curso.
        /// </summary>
        /// <param name="conta"></param>
        /// <returns></returns>
        double Calcula(ContaBancaria conta);
    }
}
