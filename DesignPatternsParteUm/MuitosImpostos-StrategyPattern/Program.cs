using System;

namespace MuitosImpostos_StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.00);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(iss);

            Console.ReadLine();
        }
    }
}
