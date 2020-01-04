using System;

namespace PatternAdapter_UtilizandoRecursosLegados
{
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            if ("mp3".Contains(audioType))
            {
                Console.WriteLine($"Playing mp3 file. Name: {fileName}.");
            } else if ("vlc".Contains(audioType) || "mp4".Contains(audioType))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            } else
            {
                Console.WriteLine($"Invalid media. {audioType} format not supported.");
            }
        }
    }
}
