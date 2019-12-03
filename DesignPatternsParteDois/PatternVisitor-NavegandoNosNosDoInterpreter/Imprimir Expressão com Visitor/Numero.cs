
using System;

namespace PatternVisitor_NavegandoNosNosDoInterpreter
{
    class Numero : IExpressao
    {
        public int Valor { get; private set; }

        public Numero(int valor)
        {
            this.Valor = valor;
        }

        public int Avalia()
        {
            return this.Valor;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}
