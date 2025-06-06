using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Start breathing activity");
            Console.WriteLine("2.Start reflection activity");
            Console.WriteLine("3.Start listing activity");
            Console.WriteLine("4. Quit");  // <- Added

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
                new Breathing().Run();
            else if (choice == "2")
                new Reflection().Run();
            else if (choice == "3")
                new Listing().Run();
            else if (choice == "4")
                Console.WriteLine("Goodbye!");  // <- Handle Quit
            else
                Console.WriteLine("Please choose an option from the menu .");
        }
        
        
    }
}