using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState_VariacaoEstadoOrcamento
{
    public class EstadoNegativo : IEstadoDeUmaConta
    {
        public void AlterarEstado(Conta conta, IEstadoDeUmaConta novoEstado)
        {
            conta.EstadoDaConta = novoEstado;
        }

        public void Depositar(Conta conta, double valor)
        {
            /*
             * conta.Saldo += valor * 0.95;
             * if (conta.Saldo > 0)
             * {
             *    AlterarEstado(conta, new EstadoPositivo());
             * }
            */
        }

        public void Sacar(Conta conta, double valor)
        {
            throw new Exception("O estado da conta está NEGATIVO, vocÊ não pode efetuar saques.");
        }
    }
}
