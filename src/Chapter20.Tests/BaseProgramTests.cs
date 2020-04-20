using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Tests
{
    abstract public class BaseProgramTests
    {
        [NotNull]
        static public ProgramWrapper? ProgramWrapper { get; set; }

        protected abstract string DefaultUrl { get; }

        [NotNull]
        public TestContext? TestContext { get; set; }

        [TestInitializeAttribute]
        public void TestInitialize()
        {
            Assert.IsNotNull(TestContext);

            // Verify ProgramWrapper is initialized by ClassInitialize in derived classes.
            //Assert.IsNotNull(ProgramWrapper);
        }

        [TestMethod]
        [DataRow("IntelliTect", @"[1-9]\d*")]
        [DataRow("Text Snippet That Does Not Exist On The Page", @"0")]
        public void Main_FindText_VerifyOccurenceCount(string findText, string countPattern)
        {
            string url = DefaultUrl;
            string expected =
                @$"Searching for '{Regex.Escape(findText)
                    }' at URL '{
                    Regex.Escape(url)
                    }'\.\s+Downloading\.{{4,}}\s+Searching\.{{3,}}\s+'{
                    Regex.Escape(findText)}' appears {countPattern} times at URL '{
                    Regex.Escape(url)
                    }'\.\s+";
            string actual = IntelliTect.TestTools.Console.ConsoleAssert.Execute("",
            () =>
            {
                ProgramWrapper.Main(new string[] { findText }).Wait();
            });
            
            Regex regex = new Regex(expected);
            Assert.IsTrue(regex.Match(actual).Success,
                $"Messages are unexpectedly different:\n\tExpected: {expected}\n\t  Actual: {actual}");
        }

        [TestMethod]
        public void Main_PassEmptyArray_ThrowException()
        {
            string expected = "ERROR: No findText argument specified.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, () =>
            {
                ProgramWrapper.Main(Array.Empty<string>()).Wait();
            });
        }

        protected virtual void AssertMainException(string messagePrefix, Exception exception)
        {
            // Default to testing for Web Exception
            AssertWebExceptionType(messagePrefix, (WebException) exception);
        }

        protected static void AssertMainException(string messagePrefix, AggregateException exception)
        {
            Assert.AreEqual<Type>(typeof(AggregateException), exception.GetType());
            if (exception is AggregateException aggregateException)
            {
                aggregateException = aggregateException!.Flatten();
                AssertWebExceptionType(messagePrefix, (WebException)aggregateException.InnerException!);
            }
        }

        protected static void AssertWebExceptionType(string messagePrefix, WebException exception)
        {
            bool isLike = IntelliTect.TestTools.Console.StringExtensions.IsLike(
                exception.Message, messagePrefix);
            string notLikeMessage = $"Messages are unexpectedly different:\n\texpected: {exception.Message}\n\tActual: {messagePrefix}";
            
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Assert.IsTrue(isLike, notLikeMessage);
            }
            else
            {
                Assert.Inconclusive(notLikeMessage);
            }
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
                    innerException!).Throw();

                return true;  // Identifhy whether the exception should report that it is handled or not.
            });
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        async public Task Main_GivenNullUri_ThrowException()
        {
            try
            {
                await ProgramWrapper.Main(new string[] { "irrelevant", null! });
                Assert.Fail("Expected exception was not thrown.");
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
                        innerException!).Throw();

                    return true;
                });
            }
        }

        [TestMethod]
        [DataRow("Bad Uri", "Could not find file *")]
        [DataRow("https://bad uri", "The filename, directory name, or volume label syntax is incorrect. *")]
        [DataRow("https://thisisanotherbadurlthatpresumablyldoesnotexist.notexist", "No such host is known. No such host is known.")]
        [ExpectedException(typeof(WebException))]
        async public Task Main_GivenBadUri_ThrowException(string uri, string messagePrefix)
        {
            try
            {
                await ProgramWrapper.Main(new string[] { "irrelevant", uri });
                Assert.Fail("Expected exception was not thrown.");
            }
            catch (Exception exception)
            {
                AssertMainException(messagePrefix, exception);
                if (exception is AggregateException aggregateException)
                {
                    // Innerexception expected to be WebException.
                    exception = aggregateException.Flatten();
                    aggregateException.Handle(innerException =>
                    {
                        // Rethrowing rather than using
                        // if condition on the type
                        ExceptionDispatchInfo.Capture(
                            innerException)
                            .Throw();
                        return true;
                    });
                }
                // WebException expected
                else throw;
            }
        }
    }

}