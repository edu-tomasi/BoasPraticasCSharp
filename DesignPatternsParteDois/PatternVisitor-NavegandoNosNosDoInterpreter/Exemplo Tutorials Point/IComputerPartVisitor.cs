﻿namespace PatternVisitor_NavegandoNosNosDoInterpreter
{
    interface IComputerPartVisitor
    {
        void visit(Computer computer);
        void visit(Mouse mouse);
        void visit(Keyboard keyboard);
        void visit(Monitor monitor);
    }
}
