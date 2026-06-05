using System;
using System.Collections.Generic;

public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> tempQuestionList = new List<string>();
    private List<string> tempPromptList = new List<string>();
    private Random _number = new Random();
    public Reflecting(string name, string description) : base (name, description)
    {
        
    }
    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.Write("--- ");
        DisplayPrompt();
        Console.Write(" ---");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration - 5);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(7);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public string GetRandomPrompt()
    {
        if (tempPromptList.Count == 0)
        {
            tempPromptList = new List<string>(_prompts);
        }

        int i = _number.Next(0, tempPromptList.Count);
        string prompt = tempPromptList[i];

        tempPromptList.RemoveAt(i);

        return prompt;
    }
    public string GetRandomQuestion()
    {
        if (tempQuestionList.Count == 0)
        {
            tempQuestionList = new List<string>(_questions);
        }

        int i = _number.Next(0, tempQuestionList.Count);
        string question = tempQuestionList[i];
        tempQuestionList.RemoveAt(i);

        return question;
    }
    public void DisplayPrompt()
    {
        Console.Write(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        Console.Write("> ");
        Console.Write(GetRandomQuestion());
        Console.Write(" ");
    }
}