
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15B.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading.Tasks;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GivenNoArgs_DownlaodIntelliTectDotCom()
        {
            string expected = "https://www.IntelliTect.com.*";

            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
                Program.Main(Array.Empty<string>()).Wait();
            });
        }

        [TestMethod]
        public void GivenNoArgs_DownlaodIntelliTectDotComAndGoogleDotCom()
        {
            string expected = @"https://IntelliTect.com.*
https://google.com......*";

            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
                Program.Main(new[] { "https://IntelliTect.com", "https://google.com"}).Wait();
            });
        }
    }
}
