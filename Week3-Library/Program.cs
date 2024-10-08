using Week3_Library;

class Program
{
    

    static void Main(string[] args)
    {
        // create a new instance (object) of the Book class
        // note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567",200);

        // Output the book information to the console
        book.DisplayInfo();
        
    }
}