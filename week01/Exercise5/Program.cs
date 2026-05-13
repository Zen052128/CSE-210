using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your username? ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string input = Console.ReadLine();
            int favnumber = int.Parse(input);
            return favnumber;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResult(int favnumber, string name)
        {
            int squarednum = SquareNumber(favnumber);
            Console.WriteLine($"{name}, the square of your number is {squarednum}");
        }

         static void Main()
            {
                DisplayWelcome();
                string name = PromptUserName();
                int number = PromptUserNumber();
                DisplayResult(number, name);
            }

        Main();
    }
}