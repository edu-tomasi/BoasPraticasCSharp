using PatternBuilder_GeradorDeNotaFiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver_ExecutandoAcoesDiferentes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Pattern Builder
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            //Mudado os métodos para formar um "Fluent Interface"/"Method Chaining". 
            criador
                .ParaEmpresa("Caelum Ensino e Inovacao")
                .ComCnpj("23.456.789/0001-12")
                .ComItem(new ItemDaNota("Item 1", 100))
                .ComItem(new ItemDaNota("Item 2", 200))
                .NaDataAtual()
                .ComObservacoes("Obs!");

            criador.AdicionarAcao(new EnviadorDeSms());
            criador.AdicionarAcao(new NotaFiscalDao());
            criador.AdicionarAcao(new EnviadorDeSms());

            NotaFiscal notaFiscal = criador.Constroi();

            Console.WriteLine(notaFiscal.ValorBruto);
            Console.WriteLine(notaFiscal.Impostos);
            #endregion

            Console.ReadKey();
        }
    }
}