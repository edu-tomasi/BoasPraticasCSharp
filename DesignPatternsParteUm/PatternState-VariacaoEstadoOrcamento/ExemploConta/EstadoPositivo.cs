using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState_VariacaoEstadoOrcamento
{
    public class EstadoPositivo : IEstadoDeUmaConta
    {
        public void AlterarEstado(Conta conta, IEstadoDeUmaConta novoEstado)
        {
            conta.EstadoDaConta = novoEstado;
        }

        public void Depositar(Conta conta, double valor)
        {
            //conta.Saldo += valor * 0.98;
        }

        public void Sacar(Conta conta, double valor)
        {
            /*
             * conta.Saldo -= valor;
             * if (conta.Saldo < 0)
             * {
             *      AlterarEstado(conta, new EstadoNegativo());
             * }
             */
        }
    }
}
