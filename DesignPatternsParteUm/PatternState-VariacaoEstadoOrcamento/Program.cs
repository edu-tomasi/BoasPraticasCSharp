using System;

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
            Conta conta = new Conta();
            conta.Depositar(100);

            conta.Sacar(50);

            conta.Depositar(100);
            conta.Sacar(250);

            conta.Sacar(10);
            #endregion
        }
    }
}
