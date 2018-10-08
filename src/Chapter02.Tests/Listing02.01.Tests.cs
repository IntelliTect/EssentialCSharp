using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_01.Tests
{
    [TestClass]
    public class LiteralValueTests
    {
        [TestMethod]
        public void Main_WriteNumbers()
        {
            const string expected =
@"42
1.618034";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}

//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_01.Tests
//{
//    [TestClass]
//    public class ProgramTests
//    {
//        [TestMethod]
//        public void Main_WriteNumbers()
//        {
//            const string expected =
//@"42
//1.618034
//1.61803398874989
//1.618033988749895
//6.023E+23
//42
//0x2A";

//            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
//                expected, Program.Main);
//        }
//    }
//}