using System;
class Book
{
    private string title;
    private string author;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return "Title: "+ Title + " , Author: "+ Author;
    }
}