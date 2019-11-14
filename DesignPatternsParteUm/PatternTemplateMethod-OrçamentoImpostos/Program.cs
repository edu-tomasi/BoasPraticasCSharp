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
            RelatorioSimples relatorioSimples = new RelatorioSimples();
            relatorioSimples.ImprimirRelatorio();
            Console.ReadKey();

            Console.Clear();

            RelatorioComplexo relatorioComplexo = new RelatorioComplexo();
            relatorioComplexo.ImprimirRelatorio();
            Console.ReadKey();

            Console.Clear();
        }
    }
}
