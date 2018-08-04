using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_15.Tests
{
    [TestClass]
    public class ConvertToPhoneNumberTests
    {
        [TestMethod]
        public void Main_InputNoPhrase_ExpectHelp()
        {
            string[] args = new string[0];
            string view =
@"ConvertToPhoneNumber.exe <phrase>
'_' indicates no standard phone button";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            () =>
            {
                ConvertToPhoneNumber.Main(args);
            });
        }

        [TestMethod]
        public void Main_InputBadChars_ExpectBlankChars()
        {
            string[] args = { "123%&67" };
            string view = "123__67";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            () =>
            {
                AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_15.ConvertToPhoneNumber.Main(args);
            });
        }

        [TestMethod]
        public void Main_InputValidPhrase_ExpectPhoneNumber()
        {
            string[] args = { "Charlie" };
            string view = "2427543";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            () =>
            {
                AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_15.ConvertToPhoneNumber.Main(args);
            });
        }
    }
}