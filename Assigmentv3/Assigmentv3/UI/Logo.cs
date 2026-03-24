using System;

namespace CyberSecurityChatbot
{
    public class AsciiArt
    {
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
=======================================
      WEAVER AWARENESS BOT
=======================================

        🔒  STAY SAFE ONLINE  🔒

 ██     ██ ███████  █████  ██    ██ ███████ ██████
██     ██ ██      ██   ██ ██    ██ ██      ██   ██
██  █  ██ █████   ███████ ██    ██ █████   ██████
██ ███ ██ ██      ██   ██  ██  ██  ██      ██   ██
 ███ ███  ███████ ██   ██   ████   ███████ ██   ██

=======================================
");

            Console.ResetColor();
        }
    }
}
