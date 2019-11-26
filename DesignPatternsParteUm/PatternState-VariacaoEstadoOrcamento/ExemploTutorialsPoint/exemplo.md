### Design Patterns - State Pattern

Mais informações sobre este exemplo podem ser encontradas no seguinte [endereço](https://www.tutorialspoint.com/design_pattern/state_pattern.htm).

No State Pattern, criamos objetos que representam vários estados e um objeto de contexto que tem seu comportamento variado conforme a mudança dos objetos de estado.

Passo à passo:
 * Crie a interface `IState` e crie a assinatura dos métodos que serão implementados.
 * Crie e implemente a inteface `IState` nas classes concretas `StartState` e `StopState`.
 * Crie a classe `Context`, esta classe será utilizada pelas classes que implementam `IState`.

Seguem alguns trechos do código que auxiliam no entendimento da solução:

###	IState.cs
```
	public interface IState
    {
        void doAction(Context context);
    }
```

### StartState.cs
```
    public class StartState : IState
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player is in start state.");
            context.state = this;
        }

        public override string ToString()
        {
            return "Start State";
        }
    }
```

### StopState.cs
```
    public class StopState : IState
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player is in stop state.");
            context.state = this;
        }

        public override string ToString()
        {
            return "Stop State";
        }
    }
```

### Context.cs
```
    public class Context
    {
        public IState state { get; set; }

        public Context()
        {
            state = null;
        }
    }
```

### Program.cs
```
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            StartState startState = new StartState();
            startState.doAction(context);

            Console.WriteLine(context.state.ToString());

            StopState stopState = new StopState();
            stopState.doAction(context);

            Console.WriteLine(context.state.ToString());

            #endregion
        }
    }
```