namespace PatternTemplateMethod_OrçamentoImpostos
{
    public abstract class TemplateRelatorio
    {
        public void ImprimirRelatorio()
        {
            CabecalhoRelatorio();
            CorpoRelatorio();
            RodapeRelatorio();
        }

        public abstract void CabecalhoRelatorio();
        public abstract void CorpoRelatorio();
        public abstract void RodapeRelatorio();
    }
}
