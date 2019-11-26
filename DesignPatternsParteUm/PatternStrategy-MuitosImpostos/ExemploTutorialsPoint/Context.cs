namespace PatternStrategy_MuitosImpostos.ExemploTutorialsPoint
{
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
}
