using System;

namespace PatternChainOfResponsibility_DescontosOrçamento.ExemploTutorialsPoint
{
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
}
