class Book
{
    string Title;
    string Author;
    string ISBN;
    int Pages;

    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        Pages = bookPages;
    }

    void DisplayInfo()
    {
        Console.WriteLine("");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Number of pages: {Pages}");
    }

    static void Main(string[] args)
    {
        // create a new instance (object) of the Book class
        // note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567",200);

        // Output the book information to the console
        book.DisplayInfo();
        
    }
}