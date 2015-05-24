using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_16.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ProjectionToAnAnonymousType()
        {
            string expected = 
@"{ FileName = Chapter14.exe, Size = * }
{ FileName = Chapter14.pdb, Size = * }
{ FileName = Chapter15.exe, Size = * }
{ FileName = Chapter15.pdb, Size = * }
{ FileName = Chapter15.Tests.dll, Size = * }
{ FileName = Chapter15.Tests.pdb, Size = * }
{ FileName = IntelliTect.Console.dll, Size = * }
{ FileName = IntelliTect.Console.pdb, Size = * }";

            IntelliTect.ConsoleView.Tester.AreLike(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}