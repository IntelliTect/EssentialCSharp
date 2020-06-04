using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_11
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_InheritanceTreeExample()
        {
            const string expected =
@"SuperSubDerivedClass
SubDerivedClass
SubDerivedClass
BaseClass";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
