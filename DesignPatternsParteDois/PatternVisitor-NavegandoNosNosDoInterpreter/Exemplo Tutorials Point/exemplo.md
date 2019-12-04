### Design Pattern - Visitor Pattern

No __Visitor Pattern__, usamos uma classe de visitantes que altera o algoritmo de execução de uma classe de elemento. Dessa maneira, o algoritmo de
execução do elemento pode variar conforme e quando o visitante varia. Esse padrão de projeto está relacionado dentro dos __Padrões Comportamentais__.

Implementação: Iremos criar uma _interface IComputerPart_ e definiremos a operação _Accept_. _Keyboard_, _Mouse_, _Monitor_ e _Computer_ são classes concretas
que implementam a _interface IComputerPart_. Iremos definir outra _interface IComputerPartVisitor_ que irá definir as operações da _classe Visitor_.
A _classe Computer_ usa o visitor concreto para executar a ação correspondente.
Nossa classe de demonstração irá usar a _classe Computer_ e _ComputerPartVisitor_ para o demonstrar o _Visitor Pattern_.

Passo à passo:
 * Crie a _interface IComputerPart.cs_.
 * Crie a _classe Keyboard.cs_ que implementa a _interface IComputerPart.cs_.
 * Crie a _classe Monitor.cs_ que implementa a _interface IComputerPart.cs_.
 * Crie a _classe Mouse.cs_ que implementa a _interface IComputerPart.cs_.
 * Crie a _classe Computer.cs_ que implementa a _interface IComputerPart.cs_.
 * Crie a _interface IComputerPartVisitor.cs_ que irá representar o _visitor_.
 * Crie a _classe ComputerPartDisplayVisitor.cs_ que implementa a _interface IComputerPartVisitor.cs_.

Exemplos de Código:
* Program.cs
```
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Tutorials Point
            IComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
            #endregion

            Console.ReadKey();
        }
    }
```

* Computer.cs
```
    class Computer : IComputerPart
    {
        IComputerPart[] parts;

        public Computer()
        {
            parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].Accept(computerPartVisitor);
            }
            computerPartVisitor.visit(this);
        }
    }
```

* Keyboard.cs
```
    class Keyboard : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
```

* Monitor.cs
```
    class Monitor : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
```

* Mouse.cs
```
    class Mouse : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
```

* IComputerPart.cs
```
    interface IComputerPart
    {
        void Accept(IComputerPartVisitor computerPartVisitor);
    }
```

* IComputerPartVisitor.cs
```
    interface IComputerPartVisitor
    {
        void visit(Computer computer);
        void visit(Mouse mouse);
        void visit(Keyboard keyboard);
        void visit(Monitor monitor);
    }
```

* ComputerPartDisplayVisitor.cs
```
    class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public void visit(Computer computer)
        {
            Console.WriteLine("Displaying Computer.");
        }

        public void visit(Mouse mouse)
        {
            Console.WriteLine("Displaying Mouse.");
        }

        public void visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying Keyboard.");
        }

        public void visit(Monitor monitor)
        {
            Console.WriteLine("Displaying Monitor.");
        }
    }
```