using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternInterpreter_ResolvendoExpressoes
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao soma = new Soma(new Numero(10), new Numero(12));
            IExpressao subtracao = new Subtracao(new Numero(5), new Numero(7));
            IExpressao multiplicacao = new Multiplicacao(new Numero(3), new Numero(5));
            IExpressao divisao = new Divisao(new Numero(4), new Numero(2));

            IExpressao somaComplexa = new Soma(soma, subtracao);
            IExpressao subtracaoComplexa = new Subtracao(soma, subtracao);

            IExpressao raizQuadrada = new RaizQuadrada(new Numero(9));

            Console.WriteLine(soma.Avalia());
            Console.WriteLine(subtracao.Avalia());
            Console.WriteLine(multiplicacao.Avalia());
            Console.WriteLine(divisao.Avalia());

            Console.WriteLine(somaComplexa.Avalia());
            Console.WriteLine(subtracaoComplexa.Avalia());

            Console.WriteLine(raizQuadrada.Avalia());

            Console.ReadKey();
        }
    }
}
