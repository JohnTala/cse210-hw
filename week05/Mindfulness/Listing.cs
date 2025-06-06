class Listing : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void Run()
    {
        Start("Welcome to Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"Prompt:\n-- {prompt} --\n");
        Console.WriteLine("You may begin listing in 3 seconds...");
        ShowSpinner(3);

        Console.WriteLine("Start listing! (Press Enter after each item)");

        DateTime endTime = DateTime.Now.AddSeconds(userInputTime);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            
            if (Console.ReadLine() != "")
            {
                count++;
            }

        }

        Console.WriteLine($"\nYou listed {count} items.");
        End();
    }
}
