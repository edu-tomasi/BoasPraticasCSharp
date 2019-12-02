namespace PatternMemento_EstadosAnterioresContrato
{
    public class Originator
    {
        public string State { get;  set; }

        public Memento saveStateToMemento()
        {
            return new Memento(State);
        }

        public void getStateFromMemento(Memento memento)
        {
            State = memento.State;
        }
    }
}
