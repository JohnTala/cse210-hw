using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade percentage? ");
        int grade = Convert.ToInt32(Console.ReadLine());
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        // Console.WriteLine($"Your grade is {letter}");

        //Lets Assume you must at least have 70 percent to pass
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations!You have passed!");
        }
        else
        {
            Console.WriteLine("Your grade was not satisfactory,Please try again!");
        }
     
       //Add sign to your letter
        int lastDigit = grade % 10;
        string sign ="";

        if (lastDigit >= 7 && grade < 97)
        {
            sign = "+";
        }

        else if (lastDigit < 3)
        {
         sign = "-";   
        }
            
       
    Console.WriteLine($"your grade is {letter}{sign}");
    }
}