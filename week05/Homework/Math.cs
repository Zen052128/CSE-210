using System;
public class Math : Assignment
{
    private string _textbookSection;
    private string _problems;
    public Math(string textbookSection, string problems, string studentName, string topic) : base (studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
    }
}