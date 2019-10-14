using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_62
{
    [TestClass]
    public class EmailDomainTests
    {
        [TestMethod]
        public void Main_EnterValidEmailWithDomain_WriteDomain()
        {
            const string expected = @"
---+---+---
 1 | 2 | 3 
---+---+---
 4 | 5 | 6 
---+---+---
 7 | 8 | 9 
---+---+---";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}