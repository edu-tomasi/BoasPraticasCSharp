using System;

namespace PatternChainOfResponsibility_DescontosOrçamento.ExemploTutorialsPoint
{
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
}
