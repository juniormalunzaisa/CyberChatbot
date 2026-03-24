namespace CyberSecurityChatbot
{
    public class NLPProcessor
    {
        public static string DetectIntent(string input)
        {
            input = input.ToLower();

            if (input.Contains("add") && input.Contains("task"))
                return "add_task";

            if (input.Contains("show") && input.Contains("task"))
                return "show_tasks";

            if (input.Contains("quiz"))
                return "quiz";

            if (input.Contains("log") || input.Contains("done for me"))
                return "show_log";

            return "unknown";
        }
    }
}
