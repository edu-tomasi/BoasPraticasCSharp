using System;

namespace PatternFacade_TrabalhandoComSistemasLegados
{
    public class ContatoCliente
    {
        private Cliente cliente;
        private Cobranca cobranca;

        public ContatoCliente(Cliente cliente, Cobranca cobranca)
        {
            this.cliente = cliente;
            this.cobranca = cobranca;
        }

        internal void Dispara()
        {
            Console.WriteLine($"Enviado o contato para o cliente {cliente.Nome}...");
        }
    }
}