using System;
using System.IO;
using System.Media;

namespace CyberSecurityChatbot
{
    public class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Audio", "ttsmp3_1773313990040.wav");

                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Audio greeting could not be played.");
            }
        }
    }
}
