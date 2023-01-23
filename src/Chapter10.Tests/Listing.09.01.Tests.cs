using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01.Tests;

[TestClass]
public class BookTests
{
    [TestMethod]
    public void Create_Book_Success()
    {
        string expected = 
            "Book { Title = Harold and the Purple Crayon, Author = Crockett Johnson, Isbn = 978-0064430227 }";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }

    [TestMethod]
    public void Create_NullParameters_Success()
    {
        Book book = new("Harold and the Purple Crayon", "Crockett Johnson", "978-0064430227");
        Book nullBook = new(null, null, null);
        Assert.IsFalse(book == nullBook);
    }
}
