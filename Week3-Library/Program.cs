class Book
{
    string Title;
    string Author;
    string ISBN;

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
        Book book = new Book();

        // This information is for one book in our library
        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";

        Book book2 = new Book();
        book2.Title = "C# Methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "55667778";

        // Output the book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();
    }
}