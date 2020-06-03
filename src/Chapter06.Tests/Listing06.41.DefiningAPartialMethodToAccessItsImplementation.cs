using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_41
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_AccessStaticField_EmployeeIdIncrements()
        {
            const string expected =
@"Inigo Montoya (1000000)
Princess Buttercup (1000001)
NextId = 1000002";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
