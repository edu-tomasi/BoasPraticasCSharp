using PatternChainOfResponsibility_DescontosOrçamento.ExemploCurso_Formato;
using PatternChainOfResponsibility_DescontosOrçamento.ExemploTutorialsPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility_DescontosOrçamento
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Desconto
            //CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            //Orcamento orcamento = new Orcamento(800);
            //orcamento.AdicionaItem(new Item("CANETA", 100));
            //orcamento.AdicionaItem(new Item("LAPIS", 100));
            //orcamento.AdicionaItem(new Item("Geladeira", 100));
            //orcamento.AdicionaItem(new Item("Fogão", 100));
            //orcamento.AdicionaItem(new Item("Microondas", 100));
            //orcamento.AdicionaItem(new Item("Cadeira", 100));
            //orcamento.AdicionaItem(new Item("Banqueta", 100));
            //orcamento.AdicionaItem(new Item("Telefone", 100));

            //double desconto = calculador.Calcula(orcamento);
            //Console.WriteLine(desconto);
            #endregion

            #region Exemplo Formato
            //GerenciadorComunicacao gerenciador = new GerenciadorComunicacao();
            //Conta conta = new Conta("Eduardo Tomasi", 100);
            //string comunicacao = gerenciador.Comunicar(conta, Formato.XML);

            //Console.WriteLine(comunicacao);
            #endregion

            #region Exemplo Tutorials Points
            AbstractLogger loggerChain = ChainPatternDemo.getChainOfLoggers();

            loggerChain.logMessage(AbstractLogger.INFO, "This is an information.");                 // Output: Standard Console::Logger: This is an information.

            loggerChain.logMessage(AbstractLogger.DEBUG, "This is an debug level information.");    // Output: File::Logger: This is an debug level information. 
                                                                                                    //         Standard Console::Logger: This is an debug level information.

            loggerChain.logMessage(AbstractLogger.ERROR, "This is an error information.");          // Output: Error Console::Logger: This is an error information.
                                                                                                    //         File::Logger: This is an error information.
                                                                                                    //         Standard Console::Logger: This is an error information.
            #endregion
            Console.ReadKey();
        }
    }
}
