using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility_DescontosOrçamento.ExemploCurso_Formato
{
    public class Conta
    {
        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string nome, double saldo)
        {
            Nome = nome;
            Saldo = saldo;
        }
    }
}
