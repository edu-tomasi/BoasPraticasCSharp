using System;

namespace PatternChainOfResponsibility_DescontosOrçamento.ExemploTutorialsPoint
{
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
}
