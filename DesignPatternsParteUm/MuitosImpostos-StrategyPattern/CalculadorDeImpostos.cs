using System;
using System.Collections.Generic;
using System.Text;

namespace MuitosImpostos_StrategyPattern
{
    /// <summary>
    /// Regra de Negócio que efetua o cálculo dos impostos.
    /// </summary>
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            #region Smell Bad - CÓDIGO PROBLEMÁTICO

            /*
            if ("ICMS".Equals(imposto))
            {
                //double icms = orcamento.Valor * 0.1;      //CODIGO PROBLEMÁTICO
                double icms = new ICMS().CalculaICMS(orcamento);
                Console.WriteLine(icms);
            }
            else if("ISS".Equals(imposto))
            {
                //double iss = orcamento.Valor * 0.06;      //CODIGO PROBLEMÁTICO
                double iss = new ISS().CalculaISS(orcamento);
                Console.WriteLine(iss);
            }*/
            #endregion

            Console.WriteLine(imposto.Calcula(orcamento));
        }
    }
}
