using System.Text;

public class PromptGenerator
{
 private List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What challenged me today?",
            "What is something kind I did for someone else today?",
            "How did I take care of myself today?",
            "What is something I learned today?",
            "What am I most grateful for today?"
        };

        private Random random = new Random();

        public string GetRandomPrompt()
        {
            return prompts[random.Next(prompts.Count)];
        }
}