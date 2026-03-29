using System.Media;

namespace CyberSecurityChatbot
{
    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Assets/greeting.wav");
                player.PlaySync();
            }
            catch
            {
                // If audio fails, continue program
            }
        }
    }
}