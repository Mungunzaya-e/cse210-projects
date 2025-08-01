using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int CountComments()
    {
        return _comments.Count();
    }

    public void AddCommentToList(Comment comment) {
        _comments.Add(comment);
    }
}