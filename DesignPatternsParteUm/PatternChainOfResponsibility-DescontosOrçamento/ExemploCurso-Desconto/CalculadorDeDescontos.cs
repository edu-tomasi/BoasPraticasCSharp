using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility_DescontosOrçamento
{
    public class CalculadorDeDescontos
    {
         public double Calcula(Orcamento orcamento)
        {
            #region Implementação Erronea 1
            //// 1a regra: mais de 5 itens
            //if (orcamento.Itens.Count > 5)
            //{
            //    return orcamento.Valor * 0.1;
            //} else if (orcamento.Valor > 500)
            //{
            //    return orcamento.Valor * 0.07;
            //}

            //// Demais regras de desconto.
            //return 0;
            #endregion

            #region Implementação Erronea 2
            //double desconto = new DescontoPorCincoItens().Desconta(orcamento);
            //if (desconto == 0)
            //{
            //    desconto = new DescontoPorMaisDeQuinhentosReais().Desconta(orcamento);
            //}

            //return desconto;
            #endregion

            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new DescontoVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconta(orcamento);

        }
    }
}
