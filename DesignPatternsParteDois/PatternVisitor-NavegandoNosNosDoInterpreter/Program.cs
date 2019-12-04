using System;

namespace PatternVisitor_NavegandoNosNosDoInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Impressão da Expressão do Visitor
            IExpressao conta = new Soma(new Numero(10), new Subtracao(new Soma(new Numero(5), new Numero(1)), new Numero(10)));
            Console.WriteLine(conta.Avalia());

            Impressora impressora = new Impressora();
            conta.Aceita(impressora);
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Exemplo Tutorials Point
            IComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
            #endregion

            Console.ReadKey();
        }
    }
}
