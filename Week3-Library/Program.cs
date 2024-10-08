class Book
{
    string Title;
    string Author;
    string ISBN;

    public Book(string bookTitle, string bookAuthor, string bookISBN)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
    }

    void DisplayInfo()
    {
        Console.WriteLine("");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
    }

    static void Main(string[] args)
    {
        // create a new instance (object) of the Book class
        // note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        // Output the book information to the console
        book.DisplayInfo();
        
    }
}