using System;

namespace PatternCommand_DiferentesAcoes
{
    public class PagaPedido : IComando
    {
        private Pedido Pedido;
        public PagaPedido(Pedido pedido)
        {
            this.Pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine($"Pagando o pedido do cliente {Pedido.Cliente}...");
            this.Pedido.Paga();
        }
    }
}
