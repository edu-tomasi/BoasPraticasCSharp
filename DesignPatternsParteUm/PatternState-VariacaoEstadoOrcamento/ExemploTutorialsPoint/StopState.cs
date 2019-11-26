using System;

namespace PatternState_VariacaoEstadoOrcamento
{
    public class StopState : IState
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player is in stop state.");
            context.state = this;
        }

        public override string ToString()
        {
            return "Stop State";
        }
    }
}
