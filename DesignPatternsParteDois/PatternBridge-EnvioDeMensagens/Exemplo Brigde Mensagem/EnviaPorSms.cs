using System;

namespace PatternBridge_EnvioDeMensagens
{
    public class EnviaPorSms : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por SMS.");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
