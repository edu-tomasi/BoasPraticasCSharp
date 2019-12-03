namespace PatternInterpreter_ResolvendoExpressoes
{
    class Divisao : IExpressao
    {
        private IExpressao _esquerda;
        private IExpressao _direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this._esquerda = esquerda;
            this._direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = _esquerda.Avalia();
            int valorDireita = _direita.Avalia();
            return valorEsquerda / valorDireita;
        }
    }
}