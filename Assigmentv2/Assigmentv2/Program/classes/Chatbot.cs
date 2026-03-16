using System;

namespace WeaverSecurityChatbot
{
    public class ChatBot
    {
        public void StartChat(string name)
        {
            while (true)
            {
                Console.Write("\nAsk a question (type 'exit' to quit): ");
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a valid question.");
                }
                else if (input.Contains("how are you"))
                {
                    Console.WriteLine("I'm running smoothly and ready to help!");
                }
                else if (input.Contains("purpose"))
                {
                    Console.WriteLine("My purpose is to help you understand cybersecurity.");
                }
                else if (input.Contains("password"))
                {
                    Console.WriteLine("Use strong passwords with numbers, symbols, and uppercase letters.");
                }
                else if (input.Contains("phishing"))
                {
                    Console.WriteLine("Phishing is when attackers trick you into giving personal information through fake emails or websites.");
                }
                else if (input.Contains("safe browsing"))
                {
                    Console.WriteLine("Always check website URLs and avoid clicking suspicious links.");
                }
                else if (input.Contains("exit"))
                {
                    Console.WriteLine($"Goodbye {name}! Stay safe online.");
                    break;
                }
                else
                {
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                }
            }
        }
    }
}
