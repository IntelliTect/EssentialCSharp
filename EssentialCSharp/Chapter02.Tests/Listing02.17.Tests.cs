using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_17.Tests
{
    [TestClass]
    public class UppercaseTests
    {
        [TestMethod]
        public void Main_InputLorem_OutputIsCapitalized()
        {
            string view =
@"Enter text: <<Lorem
>>LOREM";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                Uppercase.Main();
            });
        }
    }
}