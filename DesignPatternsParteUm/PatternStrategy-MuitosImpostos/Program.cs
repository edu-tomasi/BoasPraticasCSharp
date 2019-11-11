using System;

namespace PatternStrategy_MuitosImpostos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exemplo Imposto!");
            IImposto iss = new ISS();
            IImposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.00);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);

            Console.ReadKey();

            Console.WriteLine("Exemplo Aluguel!");
            AluguelFixo aluguelFixo = new AluguelFixo(350.00);
            AluguelPercentual aluguelPercentual = new AluguelPercentual(5.00, 1000.00);

            CalculadorDeValorAluguel calculadorAluguel = new CalculadorDeValorAluguel();
            calculadorAluguel.ObterValorAluguel(aluguelFixo);
            calculadorAluguel.ObterValorAluguel(aluguelPercentual);

            Console.ReadKey();
        }
    }
}
