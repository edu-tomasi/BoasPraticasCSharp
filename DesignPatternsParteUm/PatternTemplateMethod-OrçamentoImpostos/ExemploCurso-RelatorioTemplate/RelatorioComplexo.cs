using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTemplateMethod_OrçamentoImpostos
{
    public class RelatorioComplexo : TemplateRelatorio
    {
        public override void CabecalhoRelatorio()
        {
            Console.WriteLine($" Banco Exemplo {Environment.NewLine} End.: Rua Exemplo, Nº 123, Cruz Baixa, Cidade/UF {Environment.NewLine} Tel.: +55 47 3211-4500");
        }

        public override void CorpoRelatorio()
        {
            for (int aux = 1; aux <= 10; aux++)
            {
                Console.WriteLine($" Titular {aux}, Saldo {new Random().Next(10) * aux}.");
            }
        }

        public override void RodapeRelatorio()
        {
            Console.WriteLine($" Email: foo.bar@bancoexemplo.com.br {Environment.NewLine} {DateTime.Today}");
        }
    }
}
