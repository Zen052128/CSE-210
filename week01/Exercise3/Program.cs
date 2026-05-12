using System;

class Program
{
    static void Main(string[] args)
    {

        string notifier = "no";
        string answer2;
    
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        do 
        {
            Console.Write("What is your guess? ");
            answer2 = Console.ReadLine();
        
            int guess = int.Parse(answer2);

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                notifier = "yes";
                Console.WriteLine("You guessed it right!");
            }

        } while (!(notifier == "yes"));
    }
}