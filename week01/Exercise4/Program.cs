using System;

class Program
{
    static void Main(string[] args)
    {
       List<int> myList = new List<int>();
       Console.WriteLine("Enter a list of numbers, type 0 when finished.");
       int sum = 0;
       int userNumber;
       userNumber = -1;

        while (userNumber != 0)

        {
            Console.Write("Enter number : ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            if (userNumber != 0)
            {
                myList.Add(userNumber);
            }
            sum += userNumber;


        }

        Console.WriteLine($"The sum is : {sum}");
        float avg = ((float)sum) / myList.Count();
        Console.WriteLine($"The average : {avg}");

        int numMax = myList[0];
        for (int i = 0; i < myList.Count; i++)
        {
            //Find max number
            if (myList[i]>numMax) {
                numMax = myList[i];
            }
        
            
        }
        Console.WriteLine($"The largest number is : {numMax}");

    }
}