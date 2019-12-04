namespace PatternVisitor_NavegandoNosNosDoInterpreter
{
    interface IComputerPart
    {
        void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
