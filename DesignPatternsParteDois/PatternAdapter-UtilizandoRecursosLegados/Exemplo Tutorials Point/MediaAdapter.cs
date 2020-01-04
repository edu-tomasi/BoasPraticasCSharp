namespace PatternAdapter_UtilizandoRecursosLegados
{
    public class MediaAdapter : IMediaPlayer
    {
        private IAdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(string audioType)
        {
            if ("vlc".Contains(audioType))
            {
                advancedMusicPlayer = new VlcPlayer();
            } else if ("mp4".Contains(audioType))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if ("vlc".Contains(audioType))
            {
                advancedMusicPlayer.playVlc(fileName);
            } else if ("mp4".Contains(audioType))
            {
                advancedMusicPlayer.playMp4(fileName);
            }
        }
    }
}
