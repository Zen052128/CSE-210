using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Today;

        Running running1 = new Running(date, 60, 10);
        running1.GetSummary();

        Cycling cycling1 = new Cycling(date, 60, 2);
        cycling1.GetSummary();

        Swimming swimming1 = new Swimming(date, 60, 20);
        swimming1.GetSummary();
    }
}