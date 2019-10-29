
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
            string expected = "http://www.IntelliTect.com..............*";

            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
                Program.Main(Array.Empty<string>());
            });
        }

        [TestMethod]
        public void GivenNoArgs_DownlaodIntelliTectDotComAndGoogleDotCom()
        {
            string expected = "http://www.IntelliTect.com..............*";

            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
                Program.Main(new[] { "https://IntelliTect.com", "https://google.com"});
            });
        }
    }
}
