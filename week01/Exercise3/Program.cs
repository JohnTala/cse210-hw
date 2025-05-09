using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        bool question = true;
        int guess;
        int guesses;
        string answer;
        int magicNumber;
        while (question)
        {
            //  int magicNumber = -1;//core 2
            answer = "";
            guess = 0;
            guesses = 0;

            Console.WriteLine("what's the magic number? ");
            magicNumber = randomGenerator.Next(1, 101);
            // magicNumber = Convert.ToInt32(Console.ReadLine());//core 2


            while (guess != magicNumber)
            {

                Console.Write("what's your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your guess is {guess}");
                if (guess > magicNumber)
                {
                    Console.WriteLine("Your guess is Higher");

                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Your guess is Lower");

                }

                else
                {
                    Console.WriteLine("You guessed it!");
                }
                guesses += 1;
            }
            Console.WriteLine($"The number of attempt of guesses is {guesses}!");
            Console.WriteLine();
            Console.Write("Would like to play again? (Y/N)? ");
            answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "Y")
            {
                question = true;
            }
            else
            {
                question = false;
            }
        }
        Console.WriteLine("Thank you for playing! Good bye! ");
        

    }
}