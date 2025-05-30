
class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
     
     // Comment is a class imported and used as a custom type in the List
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
}

