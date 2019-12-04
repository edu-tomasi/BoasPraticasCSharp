namespace PatternVisitor_NavegandoNosNosDoInterpreter
{
    class Mouse : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
}
