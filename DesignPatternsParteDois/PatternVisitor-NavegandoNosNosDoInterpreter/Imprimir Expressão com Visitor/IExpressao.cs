namespace PatternVisitor_NavegandoNosNosDoInterpreter
{
    interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }
}
