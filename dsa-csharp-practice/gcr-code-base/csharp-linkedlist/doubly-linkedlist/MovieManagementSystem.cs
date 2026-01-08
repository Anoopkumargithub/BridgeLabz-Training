using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_linkedlist.doubly_linkedlist
{
    internal class MovieManagementSystem
    {
        // Node Class
        internal class MovieNode
        {
            public string Title;
            public string Director;
            public int Year;
            public double Rating;

            public MovieNode prev;
            public MovieNode next;

            public MovieNode(string title, string director, int year, double rating)
            {
                Title = title;
                Director = director;
                Year = year;
                Rating = rating;
                prev = null;
                next = null;
            }
        }

        // Doubly Linked List Class
        internal class MovieDoublyLinkedList
        {
            private MovieNode head;
            private MovieNode tail;

            // Add at Beginning
            public void AddAtBeginning(string title, string director, int year, double rating)
            {
                MovieNode newNode = new MovieNode(title, director, year, rating);

                if (head == null)
                {
                    head = tail = newNode;
                }
                else
                {
                    newNode.next = head;
                    head.prev = newNode;
                    head = newNode;
                }
            }

            // Add at End
            public void AddAtEnd(string title, string director, int year, double rating)
            {
                MovieNode newNode = new MovieNode(title, director, year, rating);

                if (tail == null)
                {
                    head = tail = newNode;
                }
                else
                {
                    tail.next = newNode;
                    newNode.prev = tail;
                    tail = newNode;
                }
            }

            // Add at Specific Position (1-based index)
            public void AddAtPosition(int position, string title, string director, int year, double rating)
            {
                if (position <= 1)
                {
                    AddAtBeginning(title, director, year, rating);
                    return;
                }

                MovieNode current = head;
                int index = 1;

                while (current != null && index < position - 1)
                {
                    current = current.next;
                    index++;
                }

                if (current == null || current.next == null)
                {
                    AddAtEnd(title, director, year, rating);
                    return;
                }

                MovieNode newNode = new MovieNode(title, director, year, rating);
                newNode.next = current.next;
                newNode.prev = current;
                current.next.prev = newNode;
                current.next = newNode;
            }

            // Remove by Movie Title
            public void RemoveByTitle(string title)
            {
                MovieNode current = head;

                while (current != null)
                {
                    if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    {
                        if (current == head)
                        {
                            head = head.next;
                            if (head != null) head.prev = null;
                        }
                        else if (current == tail)
                        {
                            tail = tail.prev;
                            tail.next = null;
                        }
                        else
                        {
                            current.prev.next = current.next;
                            current.next.prev = current.prev;
                        }

                        Console.WriteLine("Movie removed: " + title);
                        return;
                    }
                    current = current.next;
                }

                Console.WriteLine("Movie not found");
            }

            // Search by Director
            public void SearchByDirector(string director)
            {
                MovieNode current = head;
                bool found = false;

                while (current != null)
                {
                    if (current.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
                    {
                        DisplayMovie(current);
                        found = true;
                    }
                    current = current.next;
                }

                if (!found)
                    Console.WriteLine("No movies found for director: " + director);
            }

            // Search by Rating
            public void SearchByRating(double rating)
            {
                MovieNode current = head;
                bool found = false;

                while (current != null)
                {
                    if (current.Rating >= rating)
                    {
                        DisplayMovie(current);
                        found = true;
                    }
                    current = current.next;
                }

                if (!found)
                    Console.WriteLine("No movies found with rating >= " + rating);
            }

            // Update Rating by Movie Title
            public void UpdateRating(string title, double newRating)
            {
                MovieNode current = head;

                while (current != null)
                {
                    if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    {
                        current.Rating = newRating;
                        Console.WriteLine("Rating updated for: " + title);
                        return;
                    }
                    current = current.next;
                }

                Console.WriteLine("Movie not found");
            }

            // Display Forward
            public void DisplayForward()
            {
                MovieNode current = head;
                Console.WriteLine("\nMovies (Forward Order):");

                while (current != null)
                {
                    DisplayMovie(current);
                    current = current.next;
                }
            }

            // Display Reverse
            public void DisplayReverse()
            {
                MovieNode current = tail;
                Console.WriteLine("\nMovies (Reverse Order):");

                while (current != null)
                {
                    DisplayMovie(current);
                    current = current.prev;
                }
            }

            // Helper Method
            private void DisplayMovie(MovieNode movie)
            {
                Console.WriteLine(
                    $"Title: {movie.Title}, Director: {movie.Director}, Year: {movie.Year}, Rating: {movie.Rating}"
                );
            }
        }

        // Main Class
        class Program
        {
            static void Main(string[] args)
            {
                MovieDoublyLinkedList movies = new MovieDoublyLinkedList();

                movies.AddAtEnd("Inception", "Christopher Nolan", 2010, 8.8);
                movies.AddAtBeginning("Interstellar", "Christopher Nolan", 2014, 8.6);
                movies.AddAtEnd("Avatar", "James Cameron", 2009, 7.9);
                movies.AddAtPosition(2, "Titanic", "James Cameron", 1997, 7.8);

                movies.DisplayForward();
                movies.DisplayReverse();

                movies.SearchByDirector("Christopher Nolan");
                movies.SearchByRating(8.0);

                movies.UpdateRating("Avatar", 8.1);
                movies.RemoveByTitle("Titanic");

                movies.DisplayForward();
            }
        }
    }
}
