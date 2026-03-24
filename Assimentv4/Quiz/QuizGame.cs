using System;
using System.Collections.Generic;

namespace CyberSecurityChatbot
{
    public class QuizGame
    {
        private List<Question> questions = new List<Question>()
        {
            new Question { Text = "What is phishing?", Answer = "scam" },
            new Question { Text = "Should you share your password?", Answer = "no" }
        };

        public void StartQuiz()
        {
            int score = 0;

            Console.WriteLine("\nStarting Quiz...");

            foreach (var q in questions)
            {
                Console.WriteLine(q.Text);
                string input = Console.ReadLine().ToLower();

                if (input.Contains(q.Answer))
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            }

            Console.WriteLine($"Score: {score}/{questions.Count}");

            ActivityLog.Log("Quiz completed");
        }
    }
}
