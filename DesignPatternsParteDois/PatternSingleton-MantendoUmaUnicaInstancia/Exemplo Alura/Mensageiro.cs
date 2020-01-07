using System;

namespace PatternSingleton_MantendoUmaUnicaInstancia
{
    public class Mensageiro
    {
        public int Identificador { get; private set; }

        public void Envia(string mensagem)
        {
            Console.WriteLine($"{Identificador} - {mensagem}");
            Identificador++;
        }
    }
}
