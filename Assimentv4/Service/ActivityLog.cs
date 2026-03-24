using System;
using System.Collections.Generic;

namespace CyberSecurityChatbot
{
    public static class ActivityLog
    {
        private static List<string> logs = new List<string>();

        public static void Log(string action)
        {
            logs.Add($"{DateTime.Now}: {action}");
        }

        public static void ShowLog()
        {
            Console.WriteLine("\nRecent Activity:");

            int start = Math.Max(0, logs.Count - 5);

            for (int i = start; i < logs.Count; i++)
            {
                Console.WriteLine(logs[i]);
            }
        }
    }
}
