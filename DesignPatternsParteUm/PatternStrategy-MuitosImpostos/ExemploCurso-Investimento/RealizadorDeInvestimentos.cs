using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_MuitosImpostos
{
    public class RealizadorDeInvestimentos
    {
        public void Investir(ContaBancaria conta, IInvestimento investimento)
        {
            decimal retornoInvestimento = investimento.InvestirSaldo(conta.Saldo);
            conta.Depositar(retornoInvestimento);
        }
    }
}
