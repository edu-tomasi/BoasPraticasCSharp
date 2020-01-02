using System;

namespace PatternCommand_DiferentesAcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Alura
            Pedido pedido1 = new Pedido("Eduardo Tomasi", 120.0);
            Pedido pedido2 = new Pedido("Tainá Eccel", 1200.0);

            FilaDeTrabalho fila = new FilaDeTrabalho();

            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();

            Console.ReadKey(); 
            #endregion
        }
    }
}
