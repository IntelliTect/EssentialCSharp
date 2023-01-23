using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_03.Tests;

[TestClass]
public class BookTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Title_Null_ThrowsArgumentNullException() => new Book(null!, "Author", "Isbn");
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TAuthor_Null_ThrowsArgumentNullException() => new Book("Title", null!, "Isbn");
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Isbn_Null_ThrowsArgumentNullException() => new Book("Title", "Author", null!);

    [TestMethod]
    public void ToString_PurpleCrayon_PrefixByFullName()
    {
        Book book = new("Harold and the Purple Crayon", "Crockett Johnson", "978-0064430227");
        Assert.AreEqual<string>(
            "AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_03.Book { Title = Harold and the Purple Crayon, Author = Crockett Johnson, Isbn = 978-0064430227 }",
            book.ToString());
    }

    [TestMethod]
    public void Equals_SameIsbn_ReturnsTrue()
    {
        Book book1 = new("Harold and the Purple Crayon", "Crockett Johnson", "978-0064430227");
        Book book2 = new("Different", "Different", "978-0064430227");
        Assert.AreEqual<Book>(book1, book2);
    }
}
