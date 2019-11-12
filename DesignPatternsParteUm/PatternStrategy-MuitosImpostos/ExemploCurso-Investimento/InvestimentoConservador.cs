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
        public decimal InvestirSaldo(decimal saldo)
        {
            return saldo * 0.08m;
        }
    }
}
