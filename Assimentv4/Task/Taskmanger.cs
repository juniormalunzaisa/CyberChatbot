using System;

namespace CyberSecurityChatbot
{
    public class TaskManager
    {
        DatabaseHelper db = new DatabaseHelper();

        public void AddTask(string title, string desc, string reminder)
        {
            db.AddTask(title, desc, reminder);

            Console.WriteLine("Task saved.");
            ActivityLog.Log($"Task added: {title}");
        }

        public void ShowTasks()
        {
            var tasks = db.GetTasks();

            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            foreach (var t in tasks)
            {
                Console.WriteLine($"{t.Title} | {t.Description} | Reminder: {t.Reminder} | Done: {t.IsCompleted}");
            }
        }
    }
}
