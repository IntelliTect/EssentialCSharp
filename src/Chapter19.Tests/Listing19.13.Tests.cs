
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Runtime.ExceptionServices;
    using System.Threading.Tasks;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ValueTaskAsyncReturnTest()
        {
            string findText = "IntelliTect";
            string expected = @$"Searching for {findText}...
http://www.IntelliTect.com...*FOUND";

            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
                Program.Main(new string[] { findText }).Wait();
            });
        }

        [TestMethod]
        public void Main_FindTextDoesNotExist_NotFound()
        {
            string findText = "RANDOM TEXT";
            string expected = @$"Searching for {findText}...
http://www.IntelliTect.com...*missing";

            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
                Program.Main(new string[] { findText }).Wait();
            });
        }

        [TestMethod][ExpectedException(typeof(ArgumentException))]
        public void Main_PassEmptyArray_ThrowException()
        {
            try
            {
                Program.Main(Array.Empty<string>()).Wait();
            }
            catch(AggregateException exception)
            {
                ExceptionDispatchInfo.Throw(exception.Flatten().InnerExceptions[0]);
            }
        }
    }
}
