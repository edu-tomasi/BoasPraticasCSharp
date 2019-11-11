using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_MuitosImpostos
{
    public class CalculadorDeValorAluguel
    {

        public void ObterValorAluguel(IAluguel aluguel)
        {
            #region SMELL BAD!
            //AluguelPercentual aluguelPercentual = new AluguelPercentual(5, 1000.00);
            //Console.WriteLine(aluguelPercentual.Faturamento * aluguelPercentual.Percentual);

            //AluguelFixo aluguelFixo = new AluguelFixo(350.00);
            //Console.WriteLine(aluguelFixo.ValorAluguel);
            #endregion

            Console.WriteLine(aluguel.CalculaValorAluguel());
        }
    }
}
