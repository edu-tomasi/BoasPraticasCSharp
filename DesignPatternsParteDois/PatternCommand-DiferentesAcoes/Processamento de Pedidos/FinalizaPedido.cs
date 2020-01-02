﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand_DiferentesAcoes
{
    public class FinalizaPedido : IComando
    {
        private Pedido Pedido;
        public FinalizaPedido(Pedido pedido)
        {
            this.Pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine($"Finalizando o pedido do cliente {Pedido.Cliente}...");
            this.Pedido.Finaliza();
        }
    }
}
