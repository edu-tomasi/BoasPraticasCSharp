using System;

namespace PatternState_VariacaoEstadoOrcamento
{
    public class StartState : IState
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player is in start state.");
            context.state = this;
        }

        public override string ToString()
        {
            return "Start State";
        }
    }
}
