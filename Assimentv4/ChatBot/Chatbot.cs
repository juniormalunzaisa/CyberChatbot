using System;
using CyberSecurityChatbot;

namespace WeaverSecurityChatbot
{
    public class ChatBot
    {
        Random rand = new Random();

        TaskManager taskManager = new TaskManager();
        QuizGame quiz = new QuizGame();

        string[] passwordTips =
        {
            "Use a password with at least 12 characters.",
            "Avoid using personal information in your passwords.",
            "Use a password manager."
        };

        string[] scamTips =
        {
            "Never send money to strangers.",
            "Scammers pretend to be trusted companies.",
            "Always verify suspicious messages."
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
                    Console.WriteLine($"Chatbot: Goodbye {name}!");
                    break;
                }

                // NLP Intent Detection
                string intent = NLPProcessor.DetectIntent(input);

                switch (intent)
                {
                    case "add_task":
                        Console.Write("Task title: ");
                        string title = Console.ReadLine();

                        Console.Write("Description: ");
                        string desc = Console.ReadLine();

                        Console.Write("Reminder: ");
                        string reminder = Console.ReadLine();

                        taskManager.AddTask(title, desc, reminder);
                        Console.WriteLine("Task added.");
                        break;

                    case "show_tasks":
                        taskManager.ShowTasks();
                        break;

                    case "quiz":
                        quiz.StartQuiz();
                        break;

                    case "show_log":
                        ActivityLog.ShowLog();
                        break;

                    default:
                        HandleBasicChat(input);
                        break;
                }
            }
        }

        private void HandleBasicChat(string input)
        {
            if (input.Contains("worried"))
            {
                Console.WriteLine("It's okay to feel worried. Here's a tip:");
                Console.WriteLine(scamTips[rand.Next(scamTips.Length)]);
                ActivityLog.Log("User expressed worry");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine(passwordTips[rand.Next(passwordTips.Length)]);
            }
            else if (input.Contains("scam"))
            {
                Console.WriteLine(scamTips[rand.Next(scamTips.Length)]);
            }
            else
            {
                Console.WriteLine("I'm not sure I understand. Try asking about cybersecurity or tasks.");
            }
        }
    }
}