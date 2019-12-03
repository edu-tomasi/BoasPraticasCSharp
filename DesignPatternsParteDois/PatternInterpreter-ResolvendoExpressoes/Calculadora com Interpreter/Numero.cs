using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternInterpreter_ResolvendoExpressoes
{
    class Numero : IExpressao
    {
        private int _numero;

        public Numero(int numero)
        {
            this._numero = numero;
        }

        public int Avalia()
        {
            return _numero;
        }
    }
}
