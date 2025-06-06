class Breathing : Activity
{
    public void Run()
    {
        Start("Welcome to Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        DateTime endSession = DateTime.Now.AddSeconds(userInputTime);

        while (DateTime.Now < endSession)
        {
            Console.Write("Breathe In...");
            Countdown(3);
            Console.WriteLine();

            Console.Write("Now Breathe Out...");
            Countdown(6);
            Console.WriteLine("\n");
        }

        End();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
