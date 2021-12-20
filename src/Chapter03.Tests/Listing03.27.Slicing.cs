using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_27
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_GetLengthOfDimensionOf3DArray_ReturnsLength()
        {
            const string expected =
@"  0..3: C#, COBOL, Java
^3..^0: Python, Lisp, JavaScript
 3..^3: C++, TypeScript, Swift
  ..^6: C#, COBOL, Java
   6..: Python, Lisp, JavaScript
    ..: C#, COBOL, Java, C++, TypeScript, Swift, Python, Lisp, JavaScript
    ..: C#, COBOL, Java, C++, TypeScript, Swift, Python, Lisp, JavaScript";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
