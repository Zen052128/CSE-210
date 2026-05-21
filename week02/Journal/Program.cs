//As exceeding the requirement, I added an option where they can put their own thought wihout a prompt.

using System;
using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Formats.Tar;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        EntryHolder page = new EntryHolder();
        
        int menu = -1;
        while (menu != 6)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write your Thought");
            Console.WriteLine("2. Write with a Prompt");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do today? ");
            string given = Console.ReadLine();
            menu = int.Parse(given);

            List<string> PROMPTS = new List<string>{"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", " What is something I've got to be grateful today?", "What is a new thing I learned today?", "What is something I will strive to change tomorrow?"};

            if (menu == 1)
            {
                string question = "My Thought: ";
                Console.WriteLine(question);
                string answer = Console.ReadLine();
                
                Entry entryToday = new Entry();
                DateOnly dateNow = DateOnly.FromDateTime(DateTime.Now);
                entryToday._date = $"{dateNow}";
                entryToday._prompt = $"{question}";
                entryToday._entry = $"{answer}";
                page._entries.Add(entryToday);
            }

            else if (menu == 2)
            {
                Random randomGenerator = new Random();
                int number = randomGenerator.Next(0, 7);
                string question = PROMPTS[number];
                Console.WriteLine(question);
                string answer = Console.ReadLine();
                
                Entry entryToday = new Entry();
                DateOnly dateNow = DateOnly.FromDateTime(DateTime.Now);
                entryToday._date = $"{dateNow}";
                entryToday._prompt = $"{question}";
                entryToday._entry = $"{answer}";
                page._entries.Add(entryToday);
            }

            else if (menu == 3)
            {
                page.Display();
            }

            else if (menu == 4)
            {
                Console.Write("What would you name the file? ");
                string filename = Console.ReadLine();
                foreach (Entry item in page._entries)
                {
                    string line = $"{item._date}|{item._prompt}|{item._entry}";

                    File.AppendAllText(filename, line + "\n");
                }
            }

            else if (menu == 5)
            {
                page._entries.Clear();

                Console.Write("What is the name of the file to load? ");
                string filename = Console.ReadLine();

                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");
                    
                    Entry entryLoad = new Entry();
                    entryLoad._date = parts[0];
                    entryLoad._prompt = parts[1];
                    entryLoad._entry = parts[2];
                    page._entries.Add(entryLoad);
                }
            }

            else if (menu == 6)
            {
                Console.WriteLine("Have a good day!");
            }

            else
            {
                Console.WriteLine("Please choose a valid number!");
            }
        }
    }
}