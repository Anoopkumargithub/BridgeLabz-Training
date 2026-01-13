using System;

class Movie
{
    private string name;
    private string genre;
    private int duration; // Duration in minutes

    public Movie(string name, string genre, int duration)
    {
        this.name = name;
        this.genre = genre;
        this.duration = duration;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Genre
    {
        get { return genre; }
        set { genre = value; }
    }

    public int Duration
    {
        get { return duration; }
        set { duration = value; }
    }

    public override string ToString()
    {
        return "Movie: " + name + ", Genre: " + genre + ", Duration: " + duration + " mins";
    }
}