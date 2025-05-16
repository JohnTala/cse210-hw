

using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        {
            JournalApp app = new JournalApp();
            app.Run();
        }
    
    }
        
    public class JournalApp
    {
        private Journal journal = new Journal();

        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nJournal Menu:");
                Console.WriteLine("1. Write ");
                Console.WriteLine("2. Display ");
                Console.WriteLine("3. Save ");
                Console.WriteLine("4. Load ");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do ?  ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        journal.WriteNewEntry();
                        break;
                    case "2":
                        journal.DisplayAll();
                        break;
                    case "3":
                        Console.Write("Enter filename to save to: ");
                        string saveFile = Console.ReadLine();
                        JournalIO.SaveToFile(saveFile, journal.GetEntries());
                        break;
                    case "4":
                        Console.Write("Enter filename to load from: ");
                        string loadFile = Console.ReadLine();
                        var loadedEntries = JournalIO.LoadFromFile(loadFile);
                        journal.SetEntries(loadedEntries);
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
    }

