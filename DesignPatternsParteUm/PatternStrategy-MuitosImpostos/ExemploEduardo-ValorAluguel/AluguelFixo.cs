using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_MuitosImpostos
{
    public class AluguelFixo : IAluguel
    {
        public double ValorAluguel { get; private set; }

        public AluguelFixo(double valorAluguel)
        {
            ValorAluguel = valorAluguel;
        }

        public double CalculaValorAluguel()
        {
            return ValorAluguel;
        }
    }
}
