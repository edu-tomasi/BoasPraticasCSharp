### Design Pattern - Memento Pattern

No __Memento Pattern__ o objetivo é garantir que o histórico de alterações do objeto sejam registrados para que seja possível consultar os valores antes da alteração.
Este padrão de projeto está relacionado dentro dos __Padrões Comportamentais__.

Mais informações podem ser obtidas neste [endereço](https://www.tutorialspoint.com/design_pattern/memento_pattern.htm).

Implementação: o Padrão Memento usa três classes de atores. Memento contém o __estado__ de um objeto à serem restaurados. __Originator__ cria e armazena 
os __estados__ em objetos _Memento_ e _Caretaker_ é responsível em restarar o objeto de __estado__ do _Memento_.

Passo à passo:
 * Crie a _classe_ Memento.cs.
 * Crie a _classe_ Originator.cs
 * Crie a _classe_ CareTaker.cs
 * Implemente o uso do __Memento Pattern__ na classe Program.cs

Exemplos de Código:
 * Program.cs
 ```
	class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            CakeTaker careTaker = new CakeTaker();

            originator.State = "State #1";
            originator.State = "State #2";
            careTaker.Add(originator.saveStateToMemento());

            originator.State = "State #3";
            careTaker.Add(originator.saveStateToMemento());

            originator.State = "State #4";
            Console.WriteLine($"Current State: {originator.State}!");

            originator.getStateFromMemento(careTaker.Get(0));
            Console.WriteLine($"First saved State: {originator.State}!");
            originator.getStateFromMemento(careTaker.Get(1));
            Console.WriteLine($"Second saved State: {originator.State}!");

            Console.ReadKey();
        }
    }
 ```

 * Memento.cs
 ```
    public class Memento
    {
        public string State { get; private set; }

        public Memento(string state)
        {
            this.State = state;
        }
    }
 ```
  
 * Originator.cs
 ```
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
 ```

 * CareTaker.cs
 ```
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
 ```