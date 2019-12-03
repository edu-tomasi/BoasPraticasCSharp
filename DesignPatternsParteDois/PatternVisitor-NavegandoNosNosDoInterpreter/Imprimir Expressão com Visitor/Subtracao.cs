using System;

namespace PatternVisitor_NavegandoNosNosDoInterpreter
{
    class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int resultadoEsquerda = this.Esquerda.Avalia();
            int resultadoDireita = this.Direita.Avalia();

            return resultadoEsquerda - resultadoDireita;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSubtracao(this);
        }
    }
}
