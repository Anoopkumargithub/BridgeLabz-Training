using System;

class MovieImpl : IMovie
{
    private List<Movie> movies;

    public MovieImpl()
    {
        movies = new List<Movie>();
    }

    public void AddMovie(Movie movie)
    {
        movies.Add(movie);
    }

    public void SearchByGenre(string genre)
    {
        var filteredMovies = movies.Where(m => m.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
        foreach (var movie in filteredMovies)
        {
            Console.WriteLine(movie);
        }
    }

    public void SortMoviesByDuration()
    {
        var sortedMovies = movies.OrderBy(m => m.Duration).ToList();
        foreach (var movie in sortedMovies)
        {
            Console.WriteLine(movie);
        }
    }

    public void Display()
    {
        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }
    }
}