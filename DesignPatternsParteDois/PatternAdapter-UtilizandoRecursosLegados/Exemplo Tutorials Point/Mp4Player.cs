using System;

namespace PatternAdapter_UtilizandoRecursosLegados
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            Console.WriteLine($"Playing mp4 file. Name {fileName}.");
        }

        public void playVlc(string fileName)
        {
            //Do nothing.
        }
    }
}
