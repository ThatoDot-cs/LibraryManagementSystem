Library library = new Library();

try
{
    library.AddBooks(new PrintedBook("123-456-789", "The Great Gatsby", "F. Scott Fitzgerald", 5, 0.5));
    library.AddBooks(new EBoook("987-654-321", "1984", "George Orwell", 10, 1.2));

    Console.WriteLine("All Books in the Library:");
    library.DisplayAllBooks();

    Console.WriteLine("\nSearch by Title:");
    Book book = library.SearchBookByTitle("1984");
    if (book != null)
    {
        Console.WriteLine(book);
    }
    else
    {
        Console.WriteLine("Book not found.");
    }

    Console.WriteLine("\nRemoving book");
    library.RemoveBook("123-456-789");

    Console.WriteLine("\nAll books in the library after removal:");
    library.DisplayAllBooks();
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.ReadKey();



