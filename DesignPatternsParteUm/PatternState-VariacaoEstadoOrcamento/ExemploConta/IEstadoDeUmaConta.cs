using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState_VariacaoEstadoOrcamento
{
    public interface IEstadoDeUmaConta
    {
        void Sacar(Conta conta, double valor);
        void Depositar(Conta conta, double valor);
        void AlterarEstado(Conta conta, IEstadoDeUmaConta novoEstado);
    }
}
