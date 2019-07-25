using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_52
{
    [TestClass]
    public class EmailDomainTests
    {
        [TestMethod]
        public void Main_EnterValidEmailWithDomain_WriteDomain()
        {
            const string expected =
@"Enter an email address: 
<<First.Last@domain.com
>>The email domain is: domain.com";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, EmailDomain.Main);
        }
        
        [TestMethod]
        public void Main_EnterInvalidEmailWithoutDomain_WriteBlank()
        {
            const string expected =
@"Enter an email address: 
<<First.Last
>>The email domain is: ";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, EmailDomain.Main);
        }
    }
}