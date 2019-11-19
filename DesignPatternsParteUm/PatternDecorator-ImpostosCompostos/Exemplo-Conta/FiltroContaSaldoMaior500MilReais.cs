using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator_ImpostosCompostos
{
    public class FiltroContaSaldoMaior500MilReais : Filtro
    {
        public FiltroContaSaldoMaior500MilReais() { }

        public FiltroContaSaldoMaior500MilReais(Filtro outroFiltro) : base(outroFiltro) { }

        public override List<Conta> Filtrar(List<Conta> listaConta)
        {
            #region Fonte Antigo
            //var listaContaFiltrada = listaConta.Where(w => AplicarFiltroContaSaldoMaior500MilReais(w)).ToList();

            //if (OutroFiltro != null) return FiltrarComOutroFiltro(listaContaFiltrada);

            //return listaContaFiltrada; 
            #endregion

            #region Fonte com Erros
            //return FiltrarComOutroFiltro(listaConta.Where(w => AplicarFiltroContaSaldoMaior500MilReais(w)).ToList()); 
            #endregion

            List<Conta> filtrada = new List<Conta>();
            foreach(Conta c in listaConta)
            {
                if (AplicarFiltroContaSaldoMaior500MilReais(c)) filtrada.Add(c);
            }
            foreach (Conta c in FiltrarComOutroFiltro(listaConta))
            {
                filtrada.Add(c);
            }

            return filtrada;
        }

        private bool AplicarFiltroContaSaldoMaior500MilReais(Conta conta) => conta.Saldo > 500000;
    }
}
