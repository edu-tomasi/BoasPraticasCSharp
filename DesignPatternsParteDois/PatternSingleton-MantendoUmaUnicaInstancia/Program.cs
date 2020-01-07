using System;

namespace PatternSingleton_MantendoUmaUnicaInstancia
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Alura
            Mensageiro log = new MensageiroSingleton().Instancia;
            log.Envia("Olá Mundo!");
            log.Envia("Finalizando o exemplo...");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Exemplo Tutorials Point
            SingleObject obj = SingleObject.getInstance();

            obj.showMessage();
            Console.ReadKey();
            #endregion
        }
    }
}
