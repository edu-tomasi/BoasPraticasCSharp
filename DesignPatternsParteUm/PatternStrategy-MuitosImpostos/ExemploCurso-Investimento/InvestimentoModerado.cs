using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_MuitosImpostos
{
    public class InvestimentoModerado : IInvestimento
    {
        public decimal InvestirSaldo(decimal saldo)
        {
            bool escolhido = new Random().Next(101) > 50;

            if (escolhido) return saldo * 0.025m;
            else return saldo * 0.07m;
        }
    }
}
