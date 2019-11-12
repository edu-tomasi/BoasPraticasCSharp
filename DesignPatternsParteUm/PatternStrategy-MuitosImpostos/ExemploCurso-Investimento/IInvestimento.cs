using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_MuitosImpostos
{
    public interface IInvestimento
    {
        decimal InvestirSaldo(decimal saldo);
    }
}
