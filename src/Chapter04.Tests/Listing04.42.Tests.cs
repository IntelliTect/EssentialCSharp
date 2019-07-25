using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_42.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_LogicalAssignmentOperators_WriteAssignmentResult()
        {
            const string expected =
@"and = 4 
or = 15
xor = 11";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}