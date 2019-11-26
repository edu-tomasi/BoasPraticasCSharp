using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder_GeradorDeNotaFiscal
{
    public class Wrapper : IPacking
    {
        public string pack()
        {
            return "Wrapper";
        }

        public override string ToString()
        {
            return pack();
        }
    }
}
