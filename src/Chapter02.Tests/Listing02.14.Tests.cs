
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_14.Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void Main_WriteTriangle()
    {
        const string expected = @"Begin
                   /\
                  /  \
                 /    \
                /      \
               /________\
End";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Triangle.Main);
    }
}