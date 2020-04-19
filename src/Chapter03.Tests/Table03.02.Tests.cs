using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_02.Tests
{
    [TestClass]
    public class ArrayHighlightsTests
    {
        [TestMethod]
        public void Declaration()
        {
            ArrayHighlights.Declaration();
        }

        [TestMethod]
        public void Assignment()
        {
            ArrayHighlights.Assignment();
        }

        [TestMethod]
        public void ForwardAndReverseAccessingAnArray()
        {
            const string expected = @"TypeScript
Python";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, ArrayHighlights.ForwardAndReverseAccessingAnArray);
        }

        [TestMethod]
        public void Ranges()
        {
            const string expected =
                @"^3..^0: Python, Lisp, JavaScript
^3..: Python, Lisp, JavaScript
 3..^3: C++, TypeScript, Visual Basic
  ..^6: C#, COBOL, Java";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, ArrayHighlights.Ranges);
        }
    }
}