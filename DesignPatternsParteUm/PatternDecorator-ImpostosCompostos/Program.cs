using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator_ImpostosCompostos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo 1 - Decorator
            ////Imposto iss = new ISS(new ICMS()); = 80
            //Imposto iss = new ISS();

            //Orcamento orcamento = new Orcamento(500);

            //double valor = iss.Calcula(orcamento);

            //Console.WriteLine(valor);
            #endregion

            #region Exemplo 2 - Decorator
            //Orcamento orcamento = new Orcamento(1000);
            //Imposto impostoAlto = new ImpostoMuitoAlto(new ISS(new ICMS()));
            //double valorTotalImposto = impostoAlto.Calcula(orcamento);

            //Console.WriteLine(valorTotalImposto); 
            #endregion

            #region Exemplo 3 - Decorator e Template Method
            //Orcamento orcamento = new Orcamento(1000);
            //orcamento.AdicionarItem(new Item("Xiaomi Mi A2", 1000));

            //Imposto imposto = new ICMS(new ICPP(new IKCV(new ISS())));

            //double valorImposto = imposto.Calcula(orcamento);
            //Console.WriteLine(valorImposto); 
            #endregion

            Console.ReadKey();
        }
    }
}
