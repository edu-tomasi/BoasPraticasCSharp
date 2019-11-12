using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_MuitosImpostos
{
    public class RealizadorDeInvestimentos
    {
        /// <summary>
        /// Método criado por mim.
        /// </summary>
        /// <param name="conta"></param>
        /// <param name="investimento"></param>
        public void Investir(ContaBancaria conta, IInvestimento investimento)
        {
            decimal retornoInvestimento = investimento.InvestirSaldo(conta.Saldo);
            conta.Depositar(retornoInvestimento);
        }

        /// <summary>
        /// Método implementado pelo professor.
        /// </summary>
        /// <param name="conta"></param>
        /// <param name="investimento"></param>
        public void Realiza (ContaBancaria conta, IInvestimento investimento)
        {
            double resultado = investimento.Calcula(conta);
            conta.Depositar((decimal)resultado * 0.75m);
            Console.WriteLine($"Novo saldo: {conta.Saldo}");
        }
    }
}
