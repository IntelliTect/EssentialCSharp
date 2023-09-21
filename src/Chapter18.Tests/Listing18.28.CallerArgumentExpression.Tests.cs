using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_28.Tests;

#if NET7_0_OR_GREATER
[TestClass]
public class GenericExceptionTests
{
    [TestMethod]
    public void ExpectedExceptionIsThrown()
    {
        ExpectedException<DivideByZeroException>.AssertExceptionThrown(
            SampleTests.ThrowArgumentNullExceptionTest);
    }

    [TestMethod]
    public void VerifyExpectedExceptionMessage()
    {
        try
        {
            ExpectedException<InvalidOperationException>.AssertExceptionThrown(
                () => { });
        }
        catch(InvalidOperationException exception)
        {
            Assert.IsTrue(exception.Message.Contains("'() => { }'"));
        }
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void ExpectedExceptionIsNotThrown()
    {
        ExpectedException<DivideByZeroException>.AssertExceptionThrown(
            () => { });
    }
}
#endif // NET7_0_OR_GREATER
