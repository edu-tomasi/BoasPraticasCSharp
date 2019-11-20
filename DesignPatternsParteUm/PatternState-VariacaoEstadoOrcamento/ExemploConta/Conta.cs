using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState_VariacaoEstadoOrcamento
{
    public class Conta
    {
        public IEstadoDeUmaConta EstadoDaConta { get; set; }
        public double Saldo;

        public Conta()
        {
            EstadoDaConta = new EstadoPositivo();
        }


        public void Depositar(double valor)
        {
            //Saldo += valor;
            EstadoDaConta.Depositar(this, valor);
        }

        public void Sacar(double valor)
        {
            //Saldo -= valor;
            EstadoDaConta.Sacar(this, valor);
        }
    }
}
