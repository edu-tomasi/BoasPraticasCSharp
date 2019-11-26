using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder_GeradorDeNotaFiscal
{
    public class Bottle : IPacking
    {
        public string pack()
        {
            return "Bottle";
        }

        public override string ToString()
        {
            return pack();
        }
    }
}
