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
            List<IAcaoAposGererNota> listaAcoes = new List<IAcaoAposGererNota>();
            listaAcoes.Add(new EnviadorDeEmail());
            listaAcoes.Add(new NotaFiscalDao());
            listaAcoes.Add(new EnviadorDeSms());

            NotaFiscalBuilder criador = new NotaFiscalBuilder(listaAcoes);
            //Mudado os métodos para formar um "Fluent Interface"/"Method Chaining". 
            criador
                .ParaEmpresa("Caelum Ensino e Inovacao")
                .ComCnpj("23.456.789/0001-12")
                .ComItem(new ItemDaNota("Item 1", 100))
                .ComItem(new ItemDaNota("Item 2", 200))
                .NaDataAtual()
                .ComObservacoes("Obs!");

            //criador.AdicionarAcao(new EnviadorDeEmail());
            //criador.AdicionarAcao(new NotaFiscalDao());
            //criador.AdicionarAcao(new EnviadorDeSms());
            criador.AdicionarAcao(new Impressora());
            criador.AdicionarAcao(new Multiplicador(2.5));

            NotaFiscal notaFiscal = criador.Constroi();

            Console.WriteLine(notaFiscal.ValorBruto);
            Console.WriteLine(notaFiscal.Impostos);
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Exemplo Tutorials Point
            Subject subject = new Subject();

            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.setState(15);
            Console.WriteLine();
            Console.WriteLine("Second state change: 10");
            subject.setState(10);
            #endregion

            Console.ReadKey();
        }
    }
}