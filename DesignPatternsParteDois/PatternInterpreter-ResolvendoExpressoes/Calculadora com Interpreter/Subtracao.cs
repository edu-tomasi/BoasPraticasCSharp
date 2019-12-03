using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternInterpreter_ResolvendoExpressoes
{
    class Subtracao : IExpressao
    {
        private IExpressao _esquerda;
        private IExpressao _direita;

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this._esquerda = esquerda;
            this._direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = _esquerda.Avalia();
            int valorDireita = _direita.Avalia();
            return valorEsquerda - valorDireita;
        }
    }
}
