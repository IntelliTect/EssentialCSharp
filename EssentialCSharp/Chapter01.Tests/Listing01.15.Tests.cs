using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_15.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_InputInigoMontoya_WriteFirstLast()
        {
            string view =
@"Hey you!
Enter your first name: <<Inigo
>>Enter your last name: <<Montoya
>>Your full name is Inigo Montoya.";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                Program.Main();
            });
        }
    }
}