
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
<<<<<<< HEAD
            string expected = "http://www.IntelliTect.com..............*";
=======
            string expected = "https://www.IntelliTect.com.*";
>>>>>>> Create Async example #WIP

            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
<<<<<<< HEAD
                Program.Main(Array.Empty<string>());
=======
                Program.Main(Array.Empty<string>()).Wait();
>>>>>>> Create Async example #WIP
            });
        }

        [TestMethod]
        public void GivenNoArgs_DownlaodIntelliTectDotComAndGoogleDotCom()
        {
<<<<<<< HEAD
            string expected = "http://www.IntelliTect.com..............*";
=======
            string expected = @"https://IntelliTect.com.*
https://google.com......*";
>>>>>>> Create Async example #WIP

            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
<<<<<<< HEAD
                Program.Main(new[] { "https://IntelliTect.com", "https://google.com"});
=======
                Program.Main(new[] { "https://IntelliTect.com", "https://google.com"}).Wait();
>>>>>>> Create Async example #WIP
            });
        }
    }
}
