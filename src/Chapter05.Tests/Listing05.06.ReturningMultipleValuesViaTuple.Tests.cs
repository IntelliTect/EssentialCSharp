using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_06.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_InputInigoMontoya_WriteFullName()
        {
            string view =
@"Enter your first name: <<Inigo
>>Enter your last name: <<Montoya
>>Hello Inigo Montoya!";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            () =>
            {
                Program.Main();
            });
        }
    }
}