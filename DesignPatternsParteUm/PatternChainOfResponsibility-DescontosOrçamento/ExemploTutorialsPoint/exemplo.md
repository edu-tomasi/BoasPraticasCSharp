### Design Patterns - Chain of Responsibility Pattern

Mais informações sobre este exemplo podem ser encontradas no seguinte [endereço](https://www.tutorialspoint.com/design_pattern/chain_of_responsibility_pattern.htm).

Este exemplo implementa uma estratégia de __log__ quer irá exibir a mensagem dependendo do level de severidade da mensagem, fazendo a impressão da mesma ou passsando a mensagem para o próximo logger.

Passo à passo:
 * O primeiro passo é criar uma classe _abstrata_, que aqui foi chamada de `AbstractLogger`, nela temos a definição do nível de log.
 * Após isso é necessário criar as classes concretas que irão extender o _logger_, eu criei as classes `ConsoleLogger`, `ErrorLogger` e `FileLogger`.
 * Criei diferentes tipos de loggers. Associe à eles o level do erro e também o próximo logger que será executado.

 Segue trechos dos códigos:
 
 ### AbstractLogger.cs
 ```
     public abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        protected int Level;

        //proximo elemento na chain of responsibility
        public AbstractLogger NextLogger { get; set; }

        public void logMessage(int level, string messsage)
        {
            if (Level <= level) write(messsage);
            if (NextLogger != null) NextLogger.logMessage(level, messsage);
        }

        abstract protected void write(string message);
 ```

 ### ConsoleLogger.cs
 ```
     public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            Level = level;
        }

        protected override void write(string message)
        {
            Console.WriteLine($"Standard Console::Logger: {message}");
        }
    }
 ```

 ### ErrorLogger.cs
 ```
     public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            Level = level;
        }

        protected override void write(string message)
        {
            Console.WriteLine($"Error Console::Logger: {message}");
        }
    }
 ```

 ### FileLogger.cs
 ```
     public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            Level = level;
        }

        protected override void write(string message)
        {
            Console.WriteLine($"File::Logger: {message}");
        }
    }
 ```

 ### ChainPatternDemo.cs
 ```
     public class ChainPatternDemo
    {
        public static AbstractLogger getChainOfLoggers() {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.NextLogger = fileLogger;
            fileLogger.NextLogger = consoleLogger;

            return errorLogger;
        }
    }
 ```

 ### Program.cs
 ```
     class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger loggerChain = ChainPatternDemo.getChainOfLoggers();

            loggerChain.logMessage(AbstractLogger.INFO, "This is an information.");                 // Output: Standard Console::Logger: This is an information.

            loggerChain.logMessage(AbstractLogger.DEBUG, "This is an debug level information.");    // Output: File::Logger: This is an debug level information. 
                                                                                                    //         Standard Console::Logger: This is an debug level information.

            loggerChain.logMessage(AbstractLogger.ERROR, "This is an error information.");          // Output: Error Console::Logger: This is an error information.
                                                                                                    //         File::Logger: This is an error information.
                                                                                                    //         Standard Console::Logger: This is an error information.
            Console.ReadKey();
        }
    }
 ```