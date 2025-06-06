class Reflection : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this in mind in the future?"
    };

    public void Run()
    {
        Start("Welcome to Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.");

        Random rand = new Random();
        Console.WriteLine("Prompt:");
        Console.WriteLine($"-- {prompts[rand.Next(prompts.Count)]} --\n");
        Console.WriteLine("Now ponder the following questions:\n");

        DateTime endTime = DateTime.Now.AddSeconds(userInputTime);

        while (DateTime.Now < endTime)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine($"> {question}");
            ShowSpinner(5);
            Console.WriteLine();
        }

        End();
    }
}