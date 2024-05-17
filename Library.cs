// See https://aka.ms/new-console-template for more information
class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }
    public void AddBooks(Book book)
    {
        if (books.Exists(b => b.ISBN == book.ISBN))
        {
            throw new ArgumentException("A book with the same ISBN already exists.");
        }
        books.Add(book);
    }

    public void RemoveBook(string isbn)
    {
        Book book = books.Find(b => b.ISBN == isbn);

        if (book == null)
        {
            throw new ArgumentException("The book with the given ISBN does not exist.");
        }
        books.Remove(book);
    }

    public Book SearchBookByTitle(string title)
    {
        return books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    public void DisplayAllBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}