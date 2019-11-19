using System.Collections.Generic;

namespace PatternDecorator_ImpostosCompostos
{
    public abstract class Filtro
    {
        protected Filtro OutroFiltro { get; private set; }

        public Filtro() { OutroFiltro = null; }
        public Filtro(Filtro outroFiltro) { OutroFiltro = outroFiltro; }

        public abstract List<Conta> Filtrar(List<Conta> listaConta);

        public List<Conta> FiltrarComOutroFiltro(List<Conta> listaConta)
        {
            if (OutroFiltro != null) return OutroFiltro.Filtrar(listaConta);
            else return new List<Conta>();
        }
    }
}
