using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder_GeradorDeNotaFiscal
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo que não segue o Pattern
            IList<ItemDaNota> itens = new List<ItemDaNota>();

            double valorTotal = 0;
            foreach (ItemDaNota item in itens)
            {
                valorTotal += item.Valor;
            }

            double impostos = valorTotal * 0.05;

            NotaFiscal nf = new NotaFiscal("RazaoSocial", "cnpj", DateTime.Now, valorTotal, impostos, itens, "Observacao qualquer");
            #endregion

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

            NotaFiscal notaFiscal = criador.Constroi();

            Console.WriteLine(notaFiscal.ValorBruto);
            Console.WriteLine(notaFiscal.Impostos);
            #endregion

            Console.ReadKey();
        }
    }
}
