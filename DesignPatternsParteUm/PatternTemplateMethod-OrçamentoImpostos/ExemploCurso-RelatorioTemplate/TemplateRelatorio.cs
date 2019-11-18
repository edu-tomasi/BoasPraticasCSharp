namespace PatternTemplateMethod_OrçamentoImpostos
{
    public abstract class TemplateRelatorio
    {
        public void ImprimirRelatorio(TipoRelatorio tipo)
        {
            if (tipo != TipoRelatorio && Proximo != null)
                Proximo.ImprimirRelatorio(tipo);
            else if (tipo == TipoRelatorio)
            {
                CabecalhoRelatorio();
                CorpoRelatorio();
                RodapeRelatorio();
            }
        }

        public abstract void CabecalhoRelatorio();
        public abstract void CorpoRelatorio();
        public abstract void RodapeRelatorio();

        public TemplateRelatorio Proximo { get; protected set; }
        public TipoRelatorio TipoRelatorio { get; protected set; }
    }

    public enum TipoRelatorio
    {
        RelatorioSimples=1,
        RelatorioComplexo=2
    }
}
