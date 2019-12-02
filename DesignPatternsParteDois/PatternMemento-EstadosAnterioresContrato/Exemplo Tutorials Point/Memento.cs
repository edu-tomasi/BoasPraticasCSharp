namespace PatternMemento_EstadosAnterioresContrato
{
    public class Memento
    {
        public string State { get; private set; }

        public Memento(string state)
        {
            this.State = state;
        }
    }
}
