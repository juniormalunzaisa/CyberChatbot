
using CyberSecurityChatbot;
using WeaverSecurityChatbot;
using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        VoiceGreeting.PlayGreeting();
        AsciiArt.ShowLogo();

        string name = UserInteraction.AskName();
        UserInteraction.WelcomeUser(name);

        Console.WriteLine("\nType 'quiz', 'add task', 'show tasks', or 'show log' anytime.");

        ChatBot bot = new ChatBot();
        bot.StartChat(name);
    }
}