using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Math math1 = new Math("Section 5", "Problems 10-28", "Jeahlyn", "Instersecting Love");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        Writing writing1 = new Writing("Himitsu", "Kent", "Hidden Love");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInfo());
    }
}