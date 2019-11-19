using System.Collections.Generic;
using System.Linq;

namespace PatternDecorator_ImpostosCompostos
{
    public class FiltroContaSaldoMenor100Reais : Filtro
    {
        public FiltroContaSaldoMenor100Reais() { }

        public FiltroContaSaldoMenor100Reais(Filtro outroFiltro) : base(outroFiltro) { }

        public override List<Conta> Filtrar(List<Conta> listaConta)
        {
            #region Codigo Antigo
            //var listaContaFiltrada = listaConta.Where(w => AplicarFiltroContaSaldoMenor100Reais(w)).ToList();

            //if (OutroFiltro != null) return FiltrarComOutroFiltro(listaContaFiltrada);

            //return listaContaFiltrada; 
            #endregion

            #region Codigo Lógica Errada
            //return FiltrarComOutroFiltro(listaConta.Where(w => AplicarFiltroContaSaldoMenor100Reais(w)).ToList()); 
            #endregion

            List<Conta> filtrada = new List<Conta>();
            foreach(Conta c in listaConta)
            {
                if (AplicarFiltroContaSaldoMenor100Reais(c)) filtrada.Add(c);
            }
            foreach(Conta c in FiltrarComOutroFiltro(listaConta))
            {
                filtrada.Add(c);
            }

            return filtrada;
        }

        private bool AplicarFiltroContaSaldoMenor100Reais(Conta conta) => conta.Saldo < 100;
    }
}
