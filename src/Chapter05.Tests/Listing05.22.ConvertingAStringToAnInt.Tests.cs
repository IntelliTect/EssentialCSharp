using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_22.Tests
{
    [TestClass]
    public class ExceptionHandlingTests
    {
        [TestMethod]
        public void Main_InputNameAge_ExpectMonthCount()
        {
            string view =
@"Hey you!
Enter your first name: <<Inigo
>>Enter your age: <<10
>>Hi Inigo!  You are 120 months old.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            () =>
            {
                ExceptionHandling.Main();
            });
        }
    }
}
