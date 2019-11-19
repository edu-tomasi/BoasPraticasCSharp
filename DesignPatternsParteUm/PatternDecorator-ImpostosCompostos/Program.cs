using System;
using System.Collections.Generic;

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

            List<Conta> listaDeContas = new List<Conta>();
            listaDeContas.Add(new Conta(90, DateTime.Now.AddDays(-5)));
            listaDeContas.Add(new Conta(501000, DateTime.Now));
            listaDeContas.Add(new Conta(10000, DateTime.Now.AddDays(-7)));
            listaDeContas.Add(new Conta(25000, DateTime.Now.AddMonths(-1)));

            Filtro filtro = new FiltroContaSaldoMenor100Reais(new FiltroContaSaldoMaior500MilReais(new FiltroContaDataAberturaMesCorrente()));


            var resultadoFiltrado = filtro.Filtrar(listaDeContas);

            foreach (Conta item in resultadoFiltrado)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
