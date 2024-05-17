// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

class Book
{
    public string ISBN {get; private set;}
    public string Title { get;set;}
    public string Author {get;set;}
    public int CopiesAvailable {get;set;}

    public Book(string isbn, string title, string author, int copiesAvailable)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
        CopiesAvailable = copiesAvailable;
    }

    public override string ToString()
    {
        return $"{Title} by {Author} (ISBN: {ISBN}), Copies Available: {CopiesAvailable}";
    }
}
