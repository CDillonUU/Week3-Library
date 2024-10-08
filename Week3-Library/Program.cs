class Book
{
    string Title;
    string Author;
    string ISBN;

    static void Main(string[] args)
    {
        // create a new instance (object) of the Book class
        // note how the object name differs from the class name
        Book book = new Book();

        // This information is for one book in our library
        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";

        // Output the book information to the console
        Console.WriteLine($"Book title: {book.Title}");
        Console.WriteLine($"Book Author: {book.Author}");
        Console.WriteLine($"Book ISBN: {book.ISBN}");
    }
}