using System;

namespace PatternInterpreter_ResolvendoExpressoes
{
    interface IExpression
    {
        Boolean Interpret(string context);
    }
}
