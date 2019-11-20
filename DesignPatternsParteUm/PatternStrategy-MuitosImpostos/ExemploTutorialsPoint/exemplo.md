### Design Patterns - Strategy Pattern

Mais informações sobre este exemplo podem ser encontradas no seguinte [endereço](https://www.tutorialspoint.com/design_pattern/strategy_pattern.htm).

Este exemplo implementa uma estratégia de operações de __soma__, __subtração__ e __multiplicacao__.

Passo à passo:
 * Crie uma interface que cada estratégia irá implementar, neste exemplo a mesma é __IStrategy__ e nela temos a assinatura do método `doOperation()`.
 * Agora crie todas as classes concretas que irão executar as operações, criei as classes `OperacaoSoma`, `OperacaoSubstracao` e `OperacaoMultiplicacao` e implementei o método `doOperation()` específico para cada classe.
 * Criar a classe de contexto, que será reponsável por armazenar a __Strategy__ escolhida e pela chamada da operação da mesma.
 * Instancie a classe `Context` passando como parâmetro a __Strategy__ desejada, após isso basta fazer a chamada do método `executeStrategy()`.

Segue trechos dos código gerados:

### IStrategy.cs
```
    public interface IStrategy
    {
        int doOperation(int value1, int value2);
    }
```

### OperacaoMultiplicacao.cs
```
    public class OperacaoMultiplicacao : IStrategy
    {
        public int doOperation(int value1, int value2) => value1 * value2;
    }
``` 

### Context.cs
```
    public class Context
    {
        public IStrategy Strategy { get; private set; }

        public Context(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public int executeStrategy(int value1, int value2)
        {
            return Strategy.doOperation(value1, value2);
        }
    }
```

### Program.cs
```
    class Program
    {
        static void Main(string[] args)
        {
            Context contexto = new Context(new OperacaoSoma());
            Console.WriteLine("10 + 5 = " + contexto.executeStrategy(10,5));

            contexto = new Context(new OperacaoSubtracao());
            Console.WriteLine("10 - 5 = " + contexto.executeStrategy(10,5));

            contexto = new Context(new OperacaoMultiplicacao());
            Console.WriteLine("10 * 5 = " + contexto.executeStrategy(10, 5));

            Console.ReadKey();
        }
    }
```