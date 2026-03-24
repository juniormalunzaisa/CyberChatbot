using System;

namespace CyberSecurityChatbot
{
    public class UserInteraction
    {
        public static string AskName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Name cannot be empty. Please enter your name: ");
                name = Console.ReadLine();
            }

            return name;
        }

        public static void WelcomeUser(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nWelcome {name}!");
            Console.WriteLine("I am the Weaversecurity Awareness Bot.");
            Console.WriteLine("You can ask me about passwords, phishing, and safe browsing.");
            Console.ResetColor();
        }
    }
}
