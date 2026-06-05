using System;
using System.Collections.Generic;
public class Listing : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> tempPromptList = new List<string>();
    private Random _number = new Random();
    public Listing(string name, string description) : base (name, description)
    {
    
    }
    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.Write("--- ");
        GetRandomPrompt();
        Console.Write(" ---");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> list = GetListFromUser();
        _count = list.Count;
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
    }
    public void GetRandomPrompt()
    {
        if (tempPromptList.Count == 0)
        {
            tempPromptList = new List<string>(_prompts);
        }
        int i = _number.Next(0, tempPromptList.Count);
        string prompt = tempPromptList[i];
        tempPromptList.RemoveAt(i);
        Console.Write(prompt);
    }
    public List<string> GetListFromUser()
    {
        List<string> answers = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration - 5);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            answers.Add(userInput);
        }

        return answers;
    }
}