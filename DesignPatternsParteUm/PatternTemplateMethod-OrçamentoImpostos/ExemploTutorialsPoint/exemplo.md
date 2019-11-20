### Design Patterns - Template Pattern

Mais informações sobre este exemplo podem ser encontradas no seguinte [endereço](https://www.tutorialspoint.com/design_pattern/template_pattern.htm).

Este exemplo irá demonstrar o uso do __Template Pattern__ através do exemplo em que nós iremos representar dois esportes (Cricket e Futebol) através de uma classe abstrata.

Passo à passo:
 * Criaremos uma classe abstrata (`Game`) com um template do método final.
 * Vamos criar as classes concretas que extenderão a classe abstrata `Game`.

Segue trechos dos códigos gerados:

### Game.cs
```
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
```

### Cricket.cs
```
    public class Cricket : Game
    {
        protected override void EndPlay() => Console.WriteLine("Cricket Game Finished!");

        protected override void Initialize() => Console.WriteLine("Cricket Game Initialized! Start playing.");

        protected override void StartPlay() => Console.WriteLine("Cricket Game Started. Enjoy the game!");
    }
```

### Football.cs
```
    public class Football : Game
    {
        protected override void EndPlay() => Console.WriteLine("Football Game Finished!");

        protected override void Initialize() => Console.WriteLine("Football Game Initialized! Start playing.");

        protected override void StartPlay() => Console.WriteLine("Football Game Started. Enjoy the game!");
    }
```

### Program.cs
```
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.Play();
            Console.WriteLine();
            /*
                Output:
                    Cricket Game Initialized! Start playing.
                    Cricket Game Started. Enjoy the game!
                    Cricket Game Finished!
             */

            game = new Football();
            game.Play();
            /*
                Output:
                    Football Game Initialized! Start playing.
                    Football Game Started. Enjoy the game!
                    Football Game Finished!
             */

            Console.ReadKey();
        }
```