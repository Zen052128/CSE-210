using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_author}");
        Console.WriteLine($"{_length} seconds");
        Console.WriteLine();
        int totalComments = GetCommentCount();
        Console.WriteLine($"COMMENTS({totalComments})");
        Console.WriteLine();
        foreach (Comment comment in _comments)
        {
            comment.Display();     
        }
    }
}