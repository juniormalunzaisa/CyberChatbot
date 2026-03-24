using System;

namespace WeaverSecurityChatbot
{
    public class ChatBot
    {
        Random rand = new Random();

        string[] passwordTips =
        {
            "Use a password with at least 12 characters.",
            "Avoid using personal information in your passwords.",
            "Use a password manager to generate strong passwords."
        };

        string[] phishingTips =
        {
            "Be cautious of emails asking for personal information.",
            "Always check the sender before clicking links.",
            "Banks will never ask for passwords through email."
        };

        string[] privacyTips =
        {
            "Review your social media privacy settings regularly.",
            "Avoid sharing personal information publicly.",
            "Enable two-factor authentication whenever possible."
        };

        string[] scamTips =
        {
            "Never send money to someone you do not know.",
            "Scammers often pretend to be banks or companies.",
            "Always verify suspicious messages before responding."
        };

        public void StartChat(string name)
        {
            while (true)
            {
                Console.Write("\nYou: ");
                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Chatbot: Please enter a valid question.");
                    continue;
                }

                if (input.Contains("exit"))
                {
                    Console.WriteLine($"Chatbot: Goodbye {name}! Stay safe online.");
                    break;
                }

                // Sentiment detection
                if (input.Contains("worried"))
                {
                    Console.WriteLine("Chatbot: It's understandable to feel worried about cybersecurity.");
                    Console.WriteLine("Chatbot: Here is a helpful tip:");
                    Console.WriteLine(scamTips[rand.Next(scamTips.Length)]);
                }
                else if (input.Contains("curious"))
                {
                    Console.WriteLine("Chatbot: Curiosity is the first step to learning cybersecurity!");
                    Console.WriteLine(privacyTips[rand.Next(privacyTips.Length)]);
                }
                else if (input.Contains("frustrated"))
                {
                    Console.WriteLine("Chatbot: Cybersecurity can feel confusing at first.");
                    Console.WriteLine(passwordTips[rand.Next(passwordTips.Length)]);
                }

                // Keyword recognition
                else if (input.Contains("password"))
                {
                    Console.WriteLine(passwordTips[rand.Next(passwordTips.Length)]);
                }
                else if (input.Contains("phishing"))
                {
                    Console.WriteLine(phishingTips[rand.Next(phishingTips.Length)]);
                }
                else if (input.Contains("privacy"))
                {
                    Console.WriteLine(privacyTips[rand.Next(privacyTips.Length)]);
                }
                else if (input.Contains("scam"))
                {
                    Console.WriteLine(scamTips[rand.Next(scamTips.Length)]);
                }
                else if (input.Contains("how are you"))
                {
                    Console.WriteLine("Chatbot: I'm running smoothly and ready to help!");
                }
                else if (input.Contains("purpose"))
                {
                    Console.WriteLine("Chatbot: My purpose is to help you stay safe online.");
                }
                else if (input.Contains("safe browsing"))
                {
                    Console.WriteLine("Chatbot: Always check website URLs and avoid clicking suspicious links.");
                }
                else
                {
                    Console.WriteLine("Chatbot: I'm not sure I understand. Can you try rephrasing?");
                }
            }
        }
    }
}
