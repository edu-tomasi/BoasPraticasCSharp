namespace PatternVisitor_NavegandoNosNosDoInterpreter
{
    class Monitor : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
}
