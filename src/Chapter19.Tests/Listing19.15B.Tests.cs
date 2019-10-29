<<<<<<< HEAD
<<<<<<< HEAD
using AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13to14.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15B.Tests
{

    [TestClass]
    public class ProgramTests : BaseProgramTests
    {
        [ClassInitialize]
        static public void ClassInitialize(TestContext _)
        {
            ProgramWrapper = new ProgramWrapper(
                Program.Main,
                async (findText, urls, progress) => {
                    var items = Program.FindTextInWebUriAsync(findText, urls, progress);
                    IAsyncEnumerator<int> enumerator = items.GetAsyncEnumerator();
                    Assert.IsTrue(await enumerator.MoveNextAsync());
                    return enumerator.Current;
                    });
        }

        protected override void AssertMainException(string messagePrefix, Exception exception)
        {
            Assert.AreEqual<Type>(typeof(AggregateException), exception.GetType());  // Testing type first (even though the cast will also verify)

            AssertAggregateExceptionType(messagePrefix, (AggregateException)exception);
        }


        [TestMethod]
        async public Task FindTextInWebUriAsync_3Urls_Success()
        {
            await foreach (int occurrences in 
                Program.FindTextInWebUriAsync(
                    "IntelliTect", new string[] { "https://IntelliTect.com", "https://IntelliTect.com", "https://IntelliTect.com"}))
            {
                Assert.IsTrue(occurrences > 0);
            }
        }

        [TestMethod]
        public void FindTextInWebUriAsync_3Urls_ConsoleOutput()
        {
            string expected = @"Searching for IntelliTect...
.*https://Google.com....0
.*https://IntelliTect.com....29
.*https://Google.com....0";

            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected, () =>
            {
                ValueTask task = Program.Main(
                    new string[] { "IntelliTect", "https://Google.com", "https://IntelliTect.com", "https://Google.com" });
                task.AsTask().Wait();
            });
        }
    }
}
=======

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
>>>>>>> Refactoring Console invocations into Main exclusively; Started working on Async Stream example.
=======

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
>>>>>>> Refactoring Console invocations into Main exclusively; Started working on Async Stream example.
