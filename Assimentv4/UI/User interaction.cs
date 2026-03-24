using System;

namespace CyberSecurityChatbot
{
    public class UserInteraction
    {
        public static string AskName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter your name: ");
            Console.ResetColor();

            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Name cannot be empty. Please enter your name: ");
                Console.ResetColor();

                name = Console.ReadLine();
            }

            return name;
        }

        public static void WelcomeUser(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"\nWelcome {name}!");
            Console.WriteLine("I am the Weaver Cybersecurity Awareness Bot.");
            Console.WriteLine("I'm here to help you stay safe online and manage your security tasks.");

            Console.WriteLine("\nYou can ask me things like:");
            Console.WriteLine("- Password safety");
            Console.WriteLine("- Phishing attacks");
            Console.WriteLine("- Online scams");
            Console.WriteLine("- Privacy protection");

            Console.WriteLine("\nYou can also use commands:");
            Console.WriteLine("- 'add task' → Create a cybersecurity task");
            Console.WriteLine("- 'show tasks' → View your tasks");
            Console.WriteLine("- 'quiz' → Start cybersecurity quiz");
            Console.WriteLine("- 'show log' → View activity log");
            Console.WriteLine("- 'help' → Show commands again");
            Console.WriteLine("- 'exit' → Close the chatbot");

            Console.ResetColor();
        }

        public static void ShowHelp()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\nHere’s what I can do:");
            Console.WriteLine("1. Give cybersecurity tips (passwords, scams, privacy)");
            Console.WriteLine("2. Add and manage tasks");
            Console.WriteLine("3. Run a cybersecurity quiz");
            Console.WriteLine("4. Show your activity log");

            Console.WriteLine("\nCommands:");
            Console.WriteLine("- add task");
            Console.WriteLine("- show tasks");
            Console.WriteLine("- quiz");
            Console.WriteLine("- show log");
            Console.WriteLine("- exit");

            Console.ResetColor();
        }
    }
}