using System;

namespace PatternFacade_TrabalhandoComSistemasLegados
{
    public class Cobranca
    {
        private Tipo boleto;
        private Fatura fatura;

        public Cobranca(Tipo boleto, Fatura fatura)
        {
            this.boleto = boleto;
            this.fatura = fatura;
        }

        internal void Emite()
        {
            Console.WriteLine("Cobrança Emitida");
        }
    }
}