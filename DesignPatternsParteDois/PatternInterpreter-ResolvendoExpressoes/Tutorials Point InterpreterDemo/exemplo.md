### Design Pattern - Interpreter Pattern

No __Interpreter Pattern_ o objetivo é ter uma maneira de avaliar uma expressão ou uma linguagem gramatical. Este pattern involve a implementação de uma
interface existente que fala para o interpretador um particular context. Este padrão é usado no SQL parsing, motor de processamento de símbolo e etc.
Este padrão de projeto está relacionaod dentro dos __Padrão Comportamental__.

Mais informações podem ser obtidas neste [endereço](https://www.tutorialspoint.com/design_pattern/interpreter_pattern.htm).

Implementação: iremos criar uma _interface IExpression_ e classes concretas que implementam a _interface_ em questão. A classe _TerminalExpression_ foi 
definido e agirá como principal interpretador de contexto em questão. Outras classes _OrExpression_, _AndExpression_ e serão usados para criar combinações de expressões.

Passo à passo:
 * Crie a _interface_ IExpression.cs.
 * Crie a _classe_ TerminalExpression.cs.
 * Crie a _classe_ OrExpression.cs.
 * Crie a _classe_ AndExpression.cs.

Exemplo de Código:

 * Program.cs
 ```
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Tutorials Point
            IExpression isMale = getMaleExpression();
            IExpression isMarriedWoman = getMarriedWomanExpression();

            Console.WriteLine($"John is male? {isMale.Interpret("John")}");
            Console.WriteLine($"Julie is a married women? {isMarriedWoman.Interpret("Married Julie")}");
            #endregion

            Console.ReadKey();
        }

        #region Exemplo Tutorials Static Methods
        //Rule: Robert and John are male
        public static IExpression getMaleExpression()
        {
            IExpression robert = new TerminalExpression("Robert");
            IExpression john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }

        //Rule: Julie is a married women
        public static IExpression getMarriedWomanExpression()
        {
            IExpression julie = new TerminalExpression("Julie");
            IExpression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }
        #endregion
    }
 ```

 * IExpression.cs
 ```
    interface IExpression
    {
        Boolean Interpret(string context);
    }
 ```

 * TerminalExpression.cs
 ```
    class TerminalExpression : IExpression
    {
        private string _data;
        public TerminalExpression(string data)
        {
            this._data = data;
        }

        public bool Interpret(string context)
        {
            if (context.Contains(_data)) return true;
            return false;
        }
    }
 ```

 * OrExpression.cs
 ```
    class OrExpression : IExpression
    {
        private IExpression _expr1;
        private IExpression _expr2;

        public OrExpression(IExpression expr1, IExpression expr2)
        {
            this._expr1 = expr1;
            this._expr2 = expr2;
        }

        public bool Interpret(string context)
        {
            return _expr1.Interpret(context) || _expr2.Interpret(context);
        }
    }
 ```

 * AndExpression.cs
 ```
	class AndExpression : IExpression
    {
        private IExpression _expr1;
        private IExpression _expr2;

        public AndExpression(IExpression expr1, IExpression expr2)
        {
            this._expr1 = expr1;
            this._expr2 = expr2;
        }

        public bool Interpret(string context)
        {
            return _expr1.Interpret(context) && _expr2.Interpret(context);
        }
    }
 ```