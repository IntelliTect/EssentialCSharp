using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Tests;

public abstract class BaseProgramTests
{
    [NotNull]
    public static ProgramWrapper? ProgramWrapper { get; set; }

    protected abstract string DefaultUrl { get; }

    [NotNull]
    public TestContext? TestContext { get; set; }

    [TestInitialize]
    public void TestInitialize()
    {
        Assert.IsNotNull(TestContext);

        // Verify ProgramWrapper is initialized by ClassInitialize in derived classes.
        //Assert.IsNotNull(ProgramWrapper);
    }

    [TestMethod]
    [DataRow("IntelliTect", @"[1-9]\d*")]
    [DataRow("Text Snippet That Does Not Exist On The Page", @"0")]
    public void Main_FindText_VerifyOccurrenceCount(string findText, string countPattern)
    {
        string url = DefaultUrl;
        string expected =
            @$"Searching for '{Regex.Escape(findText)
                }' at URL '{
                Regex.Escape(url)
                }'\.\s+Downloading\.{{3,}}\s+Searching\.{{3,}}\s+'{
                Regex.Escape(findText)}' appears {countPattern} times at URL '{
                Regex.Escape(url)
                }'\.\s+";
        string actual = IntelliTect.TestTools.Console.ConsoleAssert.Execute("",
        () => ProgramWrapper.Main(new string[] { findText }).Wait());
        
        Regex regex = new(expected);
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
        string notLikeMessage = $"Messages are unexpectedly different on {Environment.OSVersion}:\n\texpected: {messagePrefix}\n\tActual: {exception.Message}\n\t OSInformation: {RuntimeInformation.OSDescription}";
        
        Assert.IsTrue(isLike, notLikeMessage);
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

            return true;  // Identify whether the exception should report that it is handled or not.
        });
    }

    protected static HttpClient GetMockedHttpClient()
        => new(new MockHttpClientHandler());
}

file class MockHttpClientHandler : HttpMessageHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        HttpResponseMessage response = new(HttpStatusCode.OK)
        {
            Content = new StringContent($"""
            Test Data From {GetType().Namespace}.{nameof(MockHttpClientHandler)}
            Request Uri: {request.RequestUri},
            The tests search for the word "IntelliTect" so that is can count the number of times it appears on the page.
            """)
        };
        return Task.FromResult(response);
    }
}
