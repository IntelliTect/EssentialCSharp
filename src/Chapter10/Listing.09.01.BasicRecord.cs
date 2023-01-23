using System.Diagnostics;
using System.Text;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01;

public record class Book(string? Title, string? Author, string? Isbn);

public class Program
{
    public static void Main()
    {
        (string title, string author, string isbn) = (
            "Harold and the Purple Crayon",
            "Crockett Johnson", "978-0064430227");

        // The constructor is generated using positional parameters
        Book book = new(title, author, isbn);

        // Records include a ToString() implementation
        // that returns a one-line string:
        //      Book { Title = Harold and the Purple Crayon,
        //          Author = Crockett Johnson,
        //          Isbn = 978-0064430227 }
        Console.WriteLine(book.ToString());

        // Records have a deconstructor using the 
        // positional parameters.
        if (book is (string, string, string) bookData)
        {
            Trace.Assert(book.Title == bookData.Title);
            Trace.Assert(book.Author == bookData.Author);
            Trace.Assert(book.Isbn == bookData.Isbn);
        }

        Book copy = new(title, author, isbn);

        // Records provide a custom equality operator.
        Trace.Assert(book == copy);
    }
}

