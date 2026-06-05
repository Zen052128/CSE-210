using System;
public class Breathing : Activity
{
    public Breathing(string name, string description) : base (name, description)
    {
        
    }
    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.Write($"Breathe in...");
        ShowCountDown(3);
        Console.WriteLine();
        Console.Write($"Now Breathe out...");
        ShowCountDown(3);
        Console.WriteLine();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration - 6);

        while (DateTime.Now < endTime)
        {
            Console.Write($"Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write($"Now Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}