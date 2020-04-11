﻿using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Tests
{
    abstract public class BaseProgramTests
    {
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        static public ProgramWrapper ProgramWrapper { get; set; }
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
                ProgramWrapper.Main(new string[] { findText }).Wait();
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
                ProgramWrapper.Main(new string[] { findText }).Wait();
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
                ProgramWrapper.Main(Array.Empty<string>()).Wait();
            });
        }

        [TestMethod]
        [DataRow("Bad Uri", "Could not find file *")]
        [DataRow("https://bad uri", "The filename, directory name, or volume label syntax is incorrect. *")]
        [DataRow("https://thisisanotherbadurlthatpresumablyldoesnotexist.notexist", "No such host is known. No such host is known.")]
        [ExpectedException(typeof(WebException))]
        async public ValueTask Main_GivenBadUri_ThrowException(string uri, string messagePrefix)
        {
            try
            {
                await ProgramWrapper.Main(new string[] { "irrelevant", uri });
                Assert.Fail("Expected exception was not thrown.");
            }
            catch (Exception exception)
            {
                AssertMainException(messagePrefix, exception);
                throw;
            }
        }

        protected virtual void AssertMainException(string messagePrefix, Exception exception)
        {
            // Default to testing for Web Exception
            AssertWebExceptionType(messagePrefix, (WebException)exception);
        }

        private static void AssertWebExceptionType(string messagePrefix, WebException exception)
        {
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
        async public Task FindTextInWebUri_GivenBadUri_ThrowException(string url, string messagePrefix)
        {
            try
            {
                await ProgramWrapper.FindTextInWebUri("irrelevant", new string[] { url }, null);
                Assert.Fail("Expected exception was not thrown.");
            }
            catch (AssertFailedException)
            {
                throw;
            }
            catch (Exception exception)
            {
                AssertFindTextInWebUriException(messagePrefix, exception);
                throw;
            }
        }

        virtual protected void AssertFindTextInWebUriException(string messagePrefix, Exception exception)
        {
            // Default to asserting a webException
            AssertWebExceptionType(messagePrefix, (WebException)exception);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        async public Task FindTextInWebUri_GivenNullUri_ThrowException()
        {
            try
            {
                await ProgramWrapper.FindTextInWebUri("irrelevant", null!, null);
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
    }

}