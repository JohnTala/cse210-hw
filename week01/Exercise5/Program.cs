using System;

class Program
{
    static void Main(string[] args)
    {
        //Display message
        DisplayWelcome();

        //Ask username
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        // Console.WriteLine(PromptUserName($"The userName is {userName}"));

        //Ask user favorite number
        Console.Write("Please enter your favorite number:");
        string Num = Console.ReadLine();
        int favoriteNum = int.Parse(Num);
        // Console.WriteLine(PromptUserNumber(favoriteNum));

        //accepts an integer
        int theSquareNum = SquareNumber(favoriteNum);

        // Accepts the user's name and the squared number and displays them.
        DisplayResult(userName, theSquareNum);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(string userName)
    {

        return userName;
    }
    static int PromptUserNumber(int favoriteNum)
    {
        return favoriteNum;
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string name,int squareNum)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNum}");
    }
}