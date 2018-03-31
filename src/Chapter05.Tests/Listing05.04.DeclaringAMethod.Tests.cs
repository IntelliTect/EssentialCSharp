using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_04.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_InputInigoMontoya_WriteFullName()
        {
            string view =
@"Hey you!
Enter your first name: <<Inigo
>>Enter your last name: <<Montoya
>>Hello Inigo Montoya! Your initials are I. M.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            () =>
            {
                Program.Main();
            });
        }
    }
}
