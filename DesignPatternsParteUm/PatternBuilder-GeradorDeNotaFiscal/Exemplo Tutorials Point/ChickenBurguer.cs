using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder_GeradorDeNotaFiscal
{
    public class ChickenBurguer : Burguer
    {
        public override string name()
        {
            return "Chicken Burguer";
        }

        public override float price()
        {
            return 50.5f;
        }
    }
}
