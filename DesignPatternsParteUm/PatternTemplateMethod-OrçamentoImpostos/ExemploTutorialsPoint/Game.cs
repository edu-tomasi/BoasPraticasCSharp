namespace PatternTemplateMethod_OrçamentoImpostos.ExemploTutorialsPoint
{
    public abstract class Game
    {
        protected abstract void Initialize();
        protected abstract void StartPlay();
        protected abstract void EndPlay();

        //Template Method
        public void Play()
        {
            //Inicializa o jogo
            Initialize();

            //Dá o inicio do jogo
            StartPlay();

            //Finaliza o jogo
            EndPlay();
        }
    }
}
