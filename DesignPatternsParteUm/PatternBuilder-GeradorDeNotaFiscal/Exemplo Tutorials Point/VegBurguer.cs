using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder_GeradorDeNotaFiscal
{
    public class VegBurguer : Burguer
    {
        public override string name()
        {
            return "Veg Burguer";
        }

        public override float price()
        {
            return 25;
        }
    }
}
