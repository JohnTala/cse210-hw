class Activity
{
    protected int userInputTime;

    public virtual void Start(string activityName, string description)
    {
        Console.WriteLine($"Welcome to {activityName} Activity\n");
        Console.WriteLine($"{description}\n");
        Console.Write("How long would you like your session to last (in seconds)? : ");
        userInputTime = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...\n");
        ShowSpinner(5); // Initial spinner
    }

    protected void ShowSpinner(int seconds)
    {
       

        DateTime currentDateTime = DateTime.Now;
        
        DateTime endTime = currentDateTime.AddSeconds(10);
        List<string> animation = new List<string>() { "|", "/", "-", "\\", "|", "/", "-", "\\" };
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            //Console.Write(".");
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");//replace or backspace the previous value
            i++;
            if (i >= animation.Count)
            {
                i = 0;
            }
            
        }
    }
    public void End()
    {
        Console.WriteLine($"\nYour session lasted for {userInputTime} seconds.");
        Console.WriteLine("Well done!\n");
    }
}
