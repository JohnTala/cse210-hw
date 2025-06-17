using System;

class Program
{
    static void Main(string[] args)
    {
       // Create one activity of each type
var activities = new List<Activity>()
{
    new Running(new DateTime(2022, 11, 3), 30, 3.0),       // 3 miles running in 30 minutes
    new Cycling(new DateTime(2022, 11, 3), 30, 15.0),      // 15 mph cycling for 30 minutes
    new Swimming(new DateTime(2022, 11, 3), 30, 40)        // 40 laps swimming in 30 minutes
};

// Print summaries
foreach (var activity in activities)
{
    Console.WriteLine(activity.GetSummary());
}
    }
}