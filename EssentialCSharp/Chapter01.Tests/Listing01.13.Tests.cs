using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_13.Tests
{
    [TestClass]
    public class HeyYouTests
    {
        [TestMethod]
        public void Main_InputInigoMontoya_WriteNothing()
        {
            const string expected =
@"Hey you!
Enter your first name: <<Inigo
>>Enter your last name: <<Montoya
>>";

            IntelliTect.ConsoleView.Tester.Test(
                expected, HeyYou.Main);
        }
    }
}