using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternBuilder_GeradorDeNotaFiscal;

namespace PatternObserver_ExecutandoAcoesDiferentes
{
    public class Multiplicador : IAcaoAposGererNota
    {
        public double Fator { get; private set; }
        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Ação: resultado multiplicação: " + nf.ValorBruto * Fator);
        }
    }
}
