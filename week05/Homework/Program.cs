using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments assignment1 = new Assignments("Samuel Bennett", "Multiplication");

Console.WriteLine(assignment1.GetSummary());

 Math assignment2 = new Math("Roberto Rodriguez", "Fractions", "7.3", "8-19");
 Console.WriteLine(assignment2.GetSummary());
 Console.WriteLine(assignment2.GetHomeworkList());

 Writings assignment3 = new Writings("Mary Waters", "European History", "The Causes of World War II");
 Console.WriteLine(assignment3.GetSummary());
 Console.WriteLine(assignment3.GetWritingInfo());

    }
}