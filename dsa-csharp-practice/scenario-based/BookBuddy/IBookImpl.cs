using System;
using System.Collections.Generic;

class IBookImpl : IBook
{
    List<Book> books = new List<Book>(); 
    Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

    public void addBook(Book book)
    {
        books.Add(book);
        if (!dict.ContainsKey(book.Author))
            dict[book.Author] = new List<int>();

        dict[book.Author].Add(books.Count - 1);
    }

    public void searchByAuthor(String author)
    {
        if (dict.ContainsKey(author))
        {
            List<int> indexes = dict[author];
            int size = indexes.Count;
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine(books[indexes[i]]);
            }
        } 
        else 
        {
            throw new Exception("No book found");
        }
    } 



    public void swap(int i, int j, List<Book> books)
    {
        Book temp = books[i];
        books[i] = books[j];
        books[j] = temp;
    }

    public void sortBookByAlphabetically()
    {
        for(int i = 0; i < books.Count; i++)
        {
            for(int j = i + 1; j < books.Count; j++)
            {
                string bookITitle = books[i].Title;
                string bookJTitle = books[j].Title;
                int a = string.Compare(bookITitle, bookJTitle, true);
                if(a > 0) swap(i, j, books);
            }
        }
    }

    public void Display()
    {
        for(int i = 0; i < books.Count; i++)
        {
            System.Console.WriteLine(books[i]);
        }
    }
}