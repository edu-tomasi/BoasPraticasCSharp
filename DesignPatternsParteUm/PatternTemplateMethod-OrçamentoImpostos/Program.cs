using PatternTemplateMethod_OrçamentoImpostos.ExemploTutorialsPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTemplateMethod_OrçamentoImpostos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Template Method
            //RelatorioSimples relatorioSimples = new RelatorioSimples();
            //relatorioSimples.ImprimirRelatorio();
            //Console.ReadKey();

            //Console.Clear();

            //RelatorioComplexo relatorioComplexo = new RelatorioComplexo();
            //relatorioComplexo.ImprimirRelatorio();
            //Console.ReadKey();

            //Console.Clear(); 
            #endregion


            #region Template Method + Chain of Responsability
            //TipoRelatorio tipo = TipoRelatorio.RelatorioComplexo;

            //RelatorioSimples relatorio = new RelatorioSimples(new RelatorioComplexo());
            //relatorio.ImprimirRelatorio(tipo);
            #endregion

            #region Exemplo Tutorials Point
            Game game = new Cricket();
            game.Play();
            Console.WriteLine();
            /*
                Output:
                    Cricket Game Initialized! Start playing.
                    Cricket Game Started. Enjoy the game!
                    Cricket Game Finished!
             */

            game = new Football();
            game.Play();
            /*
                Output:
                    Football Game Initialized! Start playing.
                    Football Game Started. Enjoy the game!
                    Football Game Finished!
             */

            #endregion

            Console.ReadKey();
        }
    }
}
