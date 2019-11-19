using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTemplateMethod_OrçamentoImpostos
{
    public class RelatorioSimples : TemplateRelatorio
    {
        public RelatorioSimples(TemplateRelatorio proximo = null)
        {
            TipoRelatorio = TipoRelatorio.RelatorioSimples;
            Proximo = proximo;
        }

        public override void CabecalhoRelatorio()
        {
            Console.WriteLine(" ~~ Banco Exemplo : Tel.: +55 47 3211-4500 ~~ ");
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
            CabecalhoRelatorio();
        }
    }
}
