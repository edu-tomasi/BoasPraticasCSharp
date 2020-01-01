namespace PatternBridge_EnvioDeMensagens
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }
        void Envia();
        string Formata();
    }
}
