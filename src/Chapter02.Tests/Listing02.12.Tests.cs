using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_12.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Main_WriteTriangle()
        {
            const string expected = @"begin
                   /\
                  /  \
                 /    \
                /      \
               /________\
end";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Triangle.ChapterMain);
        }
    }
}