using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_13.Tests
{
    [TestClass]
    public class HeyYouTests
    {
        [TestMethod]
        public void Main_InputInigoMontoya_WriteNothing()
        {
            string view =
@"Hey you!
Enter your first name: <<Inigo
>>Enter your last name: <<Montoya
>>";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                HeyYou.Main();
            });
        }
    }
}