using System;

namespace PatternAdapter_UtilizandoRecursosLegados
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Alura
            Cliente cliente = new Cliente();
            cliente.Name = "Eduardo";
            cliente.Endereco = "Rua Maria André de Freitas";
            cliente.DataDeNascimento = new DateTime(1994, 04, 29);


            String xml = new GeradorDeXml().GeraXml(cliente);
            Console.WriteLine(xml);

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Exemplo Tutorials Point
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.Play("mp3", "beyond the horizon.mp3");
            audioPlayer.Play("mp4", "alone.mp4");
            audioPlayer.Play("vlc", "far far away.vlc");
            audioPlayer.Play("avi", "mind me.avi");

            Console.ReadKey();
            #endregion
        }
    }
}
