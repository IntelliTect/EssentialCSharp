using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02.Tests;

[TestClass]
public class BookTests
{

    [TestMethod]
    public void Create_NullParameters_Success()
    {
        Book nullBook = new(null, null, null);
        
       _ = nullBook.GetHashCode();
    }
}
