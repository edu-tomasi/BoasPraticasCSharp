using System;

namespace PatternBridge_EnvioDeMensagens
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Bridge Mensagem
            //IMensagem mensagem = new MensagemCliente("Eduardo");
            //IMensagem mensagemSms = new MensagemAdministrativa("Tainá");

            //mensagem.Envia();
            //mensagemSms.Envia();

            IMensagem mensagemAdm = new MensagemCliente("Eduardo");
            IEnviador enviador = new EnviaPorSms();
            mensagemAdm.Enviador = enviador;

            mensagemAdm.Envia();
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Exemplo Tutorials Point
            Shape circleOne = new Circle(0, 0, 3, new RedCircle());
            circleOne.Draw();

            Shape circleTwo = new Circle(1, 1, 4, new GreenCircle());
            circleTwo.Draw();

            Console.ReadKey();
            Console.Clear(); 
            #endregion
        }
    }
}
