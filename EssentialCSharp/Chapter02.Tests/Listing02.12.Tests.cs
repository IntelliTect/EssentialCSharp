using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_12.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Main_WriteTriangle()
        {
            string view = @"begin
                   /\
                  /  \
                 /    \
                /      \
               /________\
            end";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                Triangle.Main();
            });
        }
    }
}