using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        string wordDate = date.ToString("dd MMMM YYYY");

        Running running1 = new Running(wordDate, 60, 10);
        running1.GetSummary();

        Cycling cycling1 = new Cycling(wordDate, 60, 2);
        cycling1.GetSummary();

        Swimming swimming1 = new Swimming(wordDate, 60, 20);
        swimming1.GetSummary();
    }
}