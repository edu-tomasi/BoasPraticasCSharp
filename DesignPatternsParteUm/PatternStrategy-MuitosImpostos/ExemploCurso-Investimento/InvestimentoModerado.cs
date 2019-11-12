using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_MuitosImpostos
{
    public class InvestimentoModerado : IInvestimento
    {
        private Random random;

        public InvestimentoModerado()
        {
            random = new Random();
        }

        /// <summary>
        /// Método implementado pelo professor.
        /// </summary>
        /// <param name="conta"></param>
        /// <returns></returns>
        public double Calcula(ContaBancaria conta)
        {
            if (random.Next(2) == 0)
                return (double)conta.Saldo * 0.025;
            else
                return (double)conta.Saldo * 0.007;
        }

        /// <summary>
        /// Método implementado por mim.
        /// </summary>
        /// <param name="saldo"></param>
        /// <returns></returns>
        public decimal InvestirSaldo(decimal saldo)
        {
            bool escolhido = new Random().Next(101) > 50;

            if (escolhido) return saldo * 0.025m;
            else return saldo * 0.07m;
        }
    }
}
