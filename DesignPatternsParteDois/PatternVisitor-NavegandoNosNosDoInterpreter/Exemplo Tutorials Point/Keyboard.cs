namespace PatternVisitor_NavegandoNosNosDoInterpreter
{
    class Keyboard : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
}
