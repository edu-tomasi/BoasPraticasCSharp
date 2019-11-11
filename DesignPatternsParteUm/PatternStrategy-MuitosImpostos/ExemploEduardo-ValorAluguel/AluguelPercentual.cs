using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_MuitosImpostos
{
    public class AluguelPercentual : IAluguel
    {
        public double Percentual { get; private set; }
        public double Faturamento { get; private set; }
        public double ValorMinimo { get; }

        public AluguelPercentual(double percentual, double faturamento)
        {
            Percentual = percentual / 100;
            Faturamento = faturamento;
            ValorMinimo = 250.00;
        }

        public double CalculaValorAluguel()
        {
            var valorCalculado = Faturamento * Percentual;
            if (valorCalculado < ValorMinimo)
                return ValorMinimo;

            return valorCalculado;
        }
    }
}
