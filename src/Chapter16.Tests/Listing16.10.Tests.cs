using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_10.Tests
{

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void InvokingDelegateWithoutCheckingForNull()
        {
            string expected = $@"
Keywords:
 { CSharpExpectedData.ExpectedKeywords }
Contextual Keywords:
 { CSharpExpectedData.ExpectedContextualKeywords }";


            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}