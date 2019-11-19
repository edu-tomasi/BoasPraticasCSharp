using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator_ImpostosCompostos
{
    public class FiltroContaDataAberturaMesCorrente : Filtro
    {
        public FiltroContaDataAberturaMesCorrente() { }

        public FiltroContaDataAberturaMesCorrente(Filtro outroFiltro) : base(outroFiltro) { }

        public override List<Conta> Filtrar(List<Conta> listaConta)
        {
            #region Logica errada!
            //return FiltrarComOutroFiltro(listaConta.Where(w => AplicarFiltroContaDataAberturaMesCorrente(w)).ToList()); 
            #endregion

            List<Conta> filtrada = new List<Conta>();
            foreach (Conta conta in listaConta)
            {
                if (AplicarFiltroContaDataAberturaMesCorrente(conta)) filtrada.Add(conta);
            }
            foreach (Conta conta in FiltrarComOutroFiltro(listaConta))
            {
                filtrada.Add(conta);
            }

            return filtrada;
        }

        private bool AplicarFiltroContaDataAberturaMesCorrente(Conta conta)
        {
            return conta.DataAbertura.Month == DateTime.Today.Month && conta.DataAbertura.Year == DateTime.Today.Year;
        }
    }
}
