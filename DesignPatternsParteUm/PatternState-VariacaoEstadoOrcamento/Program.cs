using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState_VariacaoEstadoOrcamento
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Orçamento
            //Orcamento reforma = new Orcamento(500);

            //Console.WriteLine(reforma.Valor);

            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);
            //reforma.Aprova();

            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);

            //reforma.Finaliza();

            ////reforma.AplicaDescontoExtra();
            ////reforma.Aprova();     
            #endregion

            #region Exemplo Conta
            //Conta conta = new Conta();
            //conta.Depositar(100);

            ////conta.Saldo = 1000000;    //Após adicionar o estado na classe conta, podemos alterar o nivel de acesso do campo "Saldo" para private.

            //conta.Sacar(50);

            //conta.Depositar(100);
            //conta.Sacar(250);

            //conta.Sacar(10);
            #endregion

            #region Exemplo Tutorials Point
            Context context = new Context();

            StartState startState = new StartState();
            startState.doAction(context);

            Console.WriteLine(context.state.ToString());

            StopState stopState = new StopState();
            stopState.doAction(context);

            Console.WriteLine(context.state.ToString());

            #endregion
        }
    }
}
