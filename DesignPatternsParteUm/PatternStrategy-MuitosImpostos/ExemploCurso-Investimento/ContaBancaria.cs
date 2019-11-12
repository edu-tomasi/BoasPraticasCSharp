using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_MuitosImpostos
{
    public class ContaBancaria
    {
        public decimal Saldo { get; private set; }

        public ContaBancaria(decimal saldo)
        {
            Saldo = saldo;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }
}
