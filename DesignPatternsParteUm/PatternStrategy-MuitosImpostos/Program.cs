using System;

namespace PatternStrategy_MuitosImpostos
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Exemplo Imposto
            /**
                Console.WriteLine("Exemplo Imposto!");
                IImposto iss = new ISS();
                IImposto icms = new ICMS();
                IImposto iccc = new ICCC();

                Orcamento orcamento = new Orcamento(3000.00);

                CalculadorDeImpostos calculador = new CalculadorDeImpostos();
                calculador.RealizaCalculo(orcamento, icms);
                calculador.RealizaCalculo(orcamento, iss);
                calculador.RealizaCalculo(orcamento, iccc);

                Console.ReadKey();
            **/
            #endregion

            #region Exemplo Aluguel
            /**
                Console.WriteLine("Exemplo Aluguel!");
                AluguelFixo aluguelFixo = new AluguelFixo(350.00);
                AluguelPercentual aluguelPercentual = new AluguelPercentual(5.00, 1000.00);

                CalculadorDeValorAluguel calculadorAluguel = new CalculadorDeValorAluguel();
                calculadorAluguel.ObterValorAluguel(aluguelFixo);
                calculadorAluguel.ObterValorAluguel(aluguelPercentual);

                Console.ReadKey();
            **/
            #endregion

            #region Exemplo Investimento

            #endregion
        }
    }
}
