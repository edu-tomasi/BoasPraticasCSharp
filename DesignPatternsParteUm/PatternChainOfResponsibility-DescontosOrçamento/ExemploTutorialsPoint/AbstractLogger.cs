namespace PatternChainOfResponsibility_DescontosOrçamento.ExemploTutorialsPoint
{
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
    }
}
