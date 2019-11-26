namespace PatternChainOfResponsibility_DescontosOrçamento.ExemploTutorialsPoint
{
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
}
