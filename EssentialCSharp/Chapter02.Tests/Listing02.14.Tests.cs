using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_14.Tests
{
    [TestClass]
    public class UppercaseTests
    {
        [TestMethod]
        public void Main_InputLorem_OutputNotCapitalized()
        {
            string view =
@"Enter text: <<Lorem
>>Lorem";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                Uppercase.Main();
            });
        }
    }
}