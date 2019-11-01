
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Runtime.ExceptionServices;
    using System.Threading.Tasks;

    public class ProgramWrapper
    {
        Action<string[]> MainMethod { get; }
        public ProgramWrapper(Action<string[]> mainMethod)
        {
            MainMethod = mainMethod;
        }

        public void Main(string[] args)
        {
            MainMethod(args);
        }
    }

    [TestClass]
    public class ProgramTests
    {
        public ProgramWrapper ProgramWrapper { get;set;}

        [TestMethod]
        public void ValueTaskAsyncReturnTest()
        {
            string findText = "IntelliTect";
            string expected = @$"Searching for {findText}...
http://www.IntelliTect.com";

            string actual = IntelliTect.TestTools.Console.ConsoleAssert.Execute("",
            () =>
            {
                Program.Main(new string[] { findText });
            });

            IntelliTect.TestTools.Console.StringExtensions.IsLike(
                $"{expected}...*", actual);
            IntelliTect.TestTools.Console.StringExtensions.IsLikeRegEx(
                @$"expected\.+^[1-9]\d*$", actual);
        }

        [TestMethod]
        public void Main_FindTextDoesNotExist_NotFound()
        {
            string findText = "RANDOM TEXT NOT ON SITE";
            string expected = @$"Searching for {findText}...
http://www.IntelliTect.com";

            string actual = IntelliTect.TestTools.Console.ConsoleAssert.Execute("",
            () =>
            {
                Program.Main(new string[] { findText });
            });

            IntelliTect.TestTools.Console.StringExtensions.IsLike(
                $"{expected}...*0", actual);
            IntelliTect.TestTools.Console.StringExtensions.IsLikeRegEx(
                @$"expected\.+0$", actual);
        }

        [TestMethod][ExpectedException(typeof(ArgumentException))]
        public void Main_PassEmptyArray_ThrowException()
        {
            try
            {
                Program.Main(Array.Empty<string>());
            }
            catch(AggregateException exception)
            {
                ExceptionDispatchInfo.Throw(exception.Flatten().InnerExceptions[0]);
            }
        }
    }
}
