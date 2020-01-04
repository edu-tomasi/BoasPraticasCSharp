using System;

namespace PatternAdapter_UtilizandoRecursosLegados
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            //Do nothing.
        }

        public void playVlc(string fileName)
        {
            Console.WriteLine($"Playing vlc file. Name : {fileName}.");
        }
    }
}
