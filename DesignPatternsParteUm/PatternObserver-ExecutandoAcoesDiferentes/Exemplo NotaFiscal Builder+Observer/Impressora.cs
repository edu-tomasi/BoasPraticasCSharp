using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternBuilder_GeradorDeNotaFiscal;

namespace PatternObserver_ExecutandoAcoesDiferentes
{
    public class Impressora : IAcaoAposGererNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Ação: Imprimindo Nota Fiscal.");
        }
    }
}
