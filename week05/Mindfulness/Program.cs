// I make it so that the prompts and questions to all will not show up twice per session. The code will delete the prompt or question that is in a temporary list so that it will not be chosen randomly again.
using System;
class Program
{
    static void Main(string[] args)
    {
        Breathing breathing1 = new Breathing("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Reflecting reflecting1 = new Reflecting("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Listing listing1 = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        int option = 0;
        while (option != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start Breathing Activity");
            Console.WriteLine("   2. Start Reflecting Activity");
            Console.WriteLine("   3. Start Listing Activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            option = int.Parse(input);
            Console.WriteLine();

            if (option == 1)
            {
                breathing1.DisplayStartMessage();
                breathing1.Run();
                breathing1.DisplayEndMessage();
            }
            else if (option == 2)
            {
                reflecting1.DisplayStartMessage();
                reflecting1.Run();
                reflecting1.DisplayEndMessage();
            }
            else if (option == 3)
            {
                listing1.DisplayStartMessage();
                listing1.Run();
                listing1.DisplayEndMessage();
            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
         }
    }
}