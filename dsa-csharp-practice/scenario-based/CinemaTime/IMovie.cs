using System;

interface IMovie
{
    void AddMovie(Movie movie);
    void SearchByGenre(string genre);
    void SortMoviesByDuration();
    void Display();
}