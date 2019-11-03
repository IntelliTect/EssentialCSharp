
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13to14.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Net;
    using System.Runtime.ExceptionServices;

    public class ProgramWrapper<TFindTextInWebUriReturn>
    {
        Action<string[]> MainMethod { get; }
        Func<TFindTextInWebUriReturn, string, string>? FindTextInWebUriMethod { get; }

        public ProgramWrapper(Action<string[]> mainMethod, Func<TFindTextInWebUriReturn, string, string>? findTextInWebUriMethod = null)
        {
            MainMethod = mainMethod;
            FindTextInWebUriMethod = findTextInWebUriMethod;
        }

        public void Main(string[] args)
        {
            MainMethod(args);
        }
        public TFindTextInWebUriReturn FindTextInWebUri(string findText, string url)
        {
            return FindTextInWebUri(url, findText);
        }
    }

    abstract public class BaseProgramTests<TFindTextInWebUriReturn>
    {
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        static public ProgramWrapper<TFindTextInWebUriReturn> ProgramWrapper { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

        [TestMethod]
        public void Main_ValidFindText_FoundAtLeastOnce()
        {
            string findText = "IntelliTect";
            string expected = @$"Searching for {findText}...
http://www.IntelliTect.com";

            string actual = IntelliTect.TestTools.Console.ConsoleAssert.Execute("",
            () =>
            {
                ProgramWrapper.Main(new string[] { findText });
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
                ProgramWrapper.Main(new string[] { findText });
            });

            IntelliTect.TestTools.Console.StringExtensions.IsLike(
                $"{expected}...*0", actual);
            IntelliTect.TestTools.Console.StringExtensions.IsLikeRegEx(
                @$"expected\.+0$", actual);
        }

        [TestMethod]
        public void Main_PassEmptyArray_ThrowException()
        {
            string expected = "ERROR: No findText argument specified.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, () =>
            {
                ProgramWrapper.Main(Array.Empty<string>());
            });
        }

        [TestMethod]
        [DataRow("Bad Uri", "Could not find file *")]
        [DataRow("https://bad uri", "The filename, directory name, or volume label syntax is incorrect. *")]
        [DataRow("https://thisisanotherbadurlthatpresumablyldoesnotexist.notexist", "No such host is known. No such host is known.")]
        [ExpectedException(typeof(WebException))]
        public void Main_GivenBadUri_ThrowException(string uri, string messagePrefix)
        {
            try
            {
                ProgramWrapper.Main(new string[] { "irrelevant", uri });
            }
            catch (Exception exception)
            {
                AssertExceptionTypeAndMessage(messagePrefix, exception);
                throw;
            }
        }

        protected virtual void AssertExceptionTypeAndMessage(string messagePrefix, Exception exception)
        {
            // Default to testing for Web Exception
            Assert.AreEqual<Type>(typeof(WebException), exception.GetType());
            Assert.IsTrue(
                IntelliTect.TestTools.Console.StringExtensions.IsLike(exception.Message, messagePrefix)
            );
        }

        protected static void AssertAggregateExceptionType(string messagePrefix, AggregateException aggregateException)
        {
            if (aggregateException.InnerExceptions.Count != 1)
            {
                Assert.Fail("Unexpected scenario with there being more than one inner exception.");
            }

            Assert.IsNotNull(aggregateException.InnerException);

            Assert.IsTrue(
                IntelliTect.TestTools.Console.StringExtensions.IsLike(aggregateException.InnerException!.Message, messagePrefix));

            aggregateException.Handle(innerException =>
            {
                // Rethrowing rather than using
                // if condition on the type
                ExceptionDispatchInfo.Capture(
                    aggregateException.InnerException!).Throw();

                return true;  // Identifhy whether the exception should report that it is handled or not.
            });
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void Main_GivenNullUri_ThrowException()
        {
            try
            {
                ProgramWrapper.Main(new string[] { "irrelevant", null! });
            }
            catch (AggregateException exception)
            {
                if (exception.InnerExceptions.Count != 1)
                {
                    throw new InvalidOperationException("Unexpected scenario with there being more than one inner exception.");
                }
                exception.Handle(innerException =>
                {
                    // Rethrowing rather than using
                    // if condition on the type
                    ExceptionDispatchInfo.Capture(
                        exception.InnerException!).Throw();

                    return true;
                });
            }
        }
    }
}
