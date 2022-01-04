using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_09.Tests
{
    [TestClass]
    public class HeyYouTests
    {
        [TestMethod]
        public void Main_StaticUsing_MethodsCalledNormally()
        {
            const string expected =
@"Hey you!
Enter your first name: <<Inigo
>>Enter your last name: <<Montoya
>>Your full name is Inigo Montoya.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, HeyYou.Main);
        }
    }
}
