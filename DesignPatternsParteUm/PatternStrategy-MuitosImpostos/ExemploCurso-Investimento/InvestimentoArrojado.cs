using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_MuitosImpostos
{
    public class InvestimentoArrojado : IInvestimento
    {
        private Random random;
        public InvestimentoArrojado()
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
            int chute = random.Next(10);
            if (chute >= 0 && chute <= 1) return (double)conta.Saldo * 0.5;
            else if (chute >= 2 && chute <= 4) return (double)conta.Saldo * 0.3;
            else return (double)conta.Saldo * 0.006;
        }

        /// <summary>
        /// Método implementado por mim.
        /// </summary>
        /// <param name="saldo"></param>
        /// <returns></returns>
        public decimal InvestirSaldo(decimal saldo)
        {
            int chances = new Random().Next(101);

            if (chances < 20) return saldo * 0.05m;
            else if (chances < 30) return saldo * 0.03m;
            else return saldo * 0.006m;
        }
    }
}
