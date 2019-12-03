using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternInterpreter_ResolvendoExpressoes
{
    class RaizQuadrada : IExpressao
    {
        private IExpressao _valor;

        public RaizQuadrada(IExpressao valor)
        {
            this._valor = valor;
        }

        public int Avalia()
        {
            int valor = _valor.Avalia();
            return (int)Math.Sqrt(valor);
        }
    }
}
