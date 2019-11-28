### Design Patterns - Observer Pattern

Mais informações sobre este exemplo podem ser encontradas no seguinte [endereço](https://www.tutorialspoint.com/design_pattern/observer_pattern.htm).

O Observer Pattern é usado quando existe uma relação de _um para muitos_ entre objetos, e se um dos objetos for modificado, os objetos dependentes serão notificados autimaticamente. Este padrão se enquadra na categoria de Behavioral Pattern (Padrões Comportamentais).

_Implementação_
Observer Pattern utiliza três classes de atores. _Subject_, _Observer_ e _Client_. _Subject_ são objetos que possuem métodos para adicionar e remover _observers_ a uma instância de _Client_.
Nós criamos uma classe abstrata de _Observer_ e uma classe concreta de _Subject_ que extenderá a classe _Observer_.

Passo à passo:
 * Criar a classe `Subject.cs`.
 * Criar a classe abstrata `Observer.cs`.
 * Criar as classes concretas `BinaryObserver.cs`, `OctalObserver.cs`, `HexaObserver.cs`.
 * Use a classe _Subject_ e as classes concretas de _Observer_.


Exemplo de códigos:

### Subject.cs
```
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int _State;
        public void setState(int value)
        {
            _State = value;
            notifyAllObservers();
        }
        
        public int getState()
        {
            return _State;
        }

        public void attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void notifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.update();
            }
        }

    }
```

### Observer.cs
```
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void update();
    }
```

### BinaryObserver.cs / OctalObserver.cs / HexaObserver.cs
```
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Binary String: " + Convert.ToString(subject.getState(), 2));
        }
    }

	public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }
        public override void update()
        {
            Console.WriteLine("Octal String: " + Convert.ToString(subject.getState(), 8));
        }
    }

	public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }
        public override void update()
        {
            Console.WriteLine("Hex String: " + subject.getState().ToString("X4").ToUpper());
        }
    }
```

### Program.cs
```
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.setState(15);
            Console.WriteLine();
            Console.WriteLine("Second state change: 10");
            subject.setState(10);

            Console.ReadKey();
        }
    }
```