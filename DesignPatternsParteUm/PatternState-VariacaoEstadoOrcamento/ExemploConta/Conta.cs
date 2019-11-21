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
        public IEstado EstadoConta { get; set; }
        private double Saldo;

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

        /* AO MANTER A INTERFACE EM UMA CLASSE DIFERENTE O SEGUINTE PROBLEMA OCORRE, O VALOR DO SALDO PODE SER ALTERADO DIRETAMENTE, POIS SUA VISIBILIDADE PRECISA ESTAR DISPONÍVEL PARA TODOS (PUBLIC) PARA QUE O ESTADO CONSIGA ATUALIZAR O SALDO.*/
        /* ABAIXO IREMOS RESOLVER ESTE PROBLEMA.*/
        /* MAIS UMA OPÇÃO PARA TRATAR ESTE PROBLEMA SERIA SEGMENTAR A CLASSE CONTA EM "PARTIAL", ASSIM PODERIAMOS TER OS CONCEITOS DO OBJETO E DO ESTADO SEPARADO EM DOIS ARQUIVOS DIFERENTES.*/

        public interface IEstado
        {
            void Sacar(Conta conta, double valor);
            void Depositar(Conta conta, double valor);
            void AlterarEstado(Conta conta, IEstado novoEstado);
        }

        public class Positivo : IEstado
        {
            public void AlterarEstado(Conta conta, IEstado novoEstado)
            {
                conta.EstadoConta = novoEstado;
            }

            public void Depositar(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.98;
            }

            public void Sacar(Conta conta, double valor)
            {
                conta.Saldo -= valor;

                if (conta.Saldo < 0)
                {
                    AlterarEstado(conta, new Negativo());
                }
            }
        }

        public class Negativo : IEstado
        {
            public void AlterarEstado(Conta conta, IEstado novoEstado)
            {
                conta.EstadoConta = novoEstado;
            }

            public void Depositar(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.95;
                if (conta.Saldo > 0)
                {
                    AlterarEstado(conta, new Positivo());
                }
            }

            public void Sacar(Conta conta, double valor)
            {
                throw new Exception("O estado da conta está NEGATIVO, vocÊ não pode efetuar saques.");
            }
        }
    }
}
