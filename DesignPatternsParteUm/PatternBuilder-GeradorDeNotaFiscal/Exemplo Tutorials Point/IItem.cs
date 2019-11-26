using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder_GeradorDeNotaFiscal
{
    public interface IItem
    {
        String name();
        IPacking packing();
        float price();
    }
}
