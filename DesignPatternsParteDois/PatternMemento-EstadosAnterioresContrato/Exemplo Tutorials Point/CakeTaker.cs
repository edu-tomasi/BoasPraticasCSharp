using System.Collections.Generic;

namespace PatternMemento_EstadosAnterioresContrato
{
    public class CakeTaker
    {
        private IList<Memento> mementoList = new List<Memento>();

        public void Add(Memento state)
        {
            mementoList.Add(state);
        }

        public Memento Get(int index)
        {
            return mementoList[index];
        }
    }
}
