using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> NUMBERS = new List<int>();

        int usernumber = -1;
        while (usernumber != 0)
        {
            Console.Write("Give a number (0 to quit): ");
            string number = Console.ReadLine();
            usernumber = int.Parse(number);

            if (usernumber != 0)
            {
                NUMBERS.Add(usernumber);
            }
        }

        int sum = 0;
        int highest = 0;

        foreach (int item in NUMBERS)
        {
            sum += item;

            if (item > highest)
            {
                highest = item;
            }
        }

        int all = NUMBERS.Count;

        float average = ((float)sum) / all;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The highest number is: {highest}");
    }
}