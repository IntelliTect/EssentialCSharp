using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_17.Tests
{
    [TestClass]
    public class UppercaseTests
    {
        [TestMethod]
        public void Main_InputLorem_OutputIsCapitalized()
        {
            const string expected =
@"Enter text: <<Lorem
>>LOREM";

            Intellitect.ConsoleView.Tester.Test(
                expected, Uppercase.ChapterMain);
        }
    }
}