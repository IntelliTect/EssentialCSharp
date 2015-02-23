using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_17.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_InputInigoMontoya_WriteLastFirst()
        {
            string view =
@"Hey you!
Enter your first name: <<Inigo
>>Enter your last name: <<Montoya
>>Your full name is Montoya, Inigo.";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                Listing01_17.Program.Main();
            });
        }
    }
}