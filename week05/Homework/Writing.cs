using System;
public class Writing : Assignment
{
    private string _title;
    public Writing(string title, string studentName, string topic) : base (studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInfo()
    {
        return $"{_title} by {_studentName}";
    }
}