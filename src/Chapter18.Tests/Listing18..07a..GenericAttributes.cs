using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_07a.Tests;

[TestClass]
public class GenericExceptionTests
{
    [TestMethod]
    public void ExpectedExceptionIsThrown()
    {
        ExpectedException<ArgumentNullException>.AssertExceptionThrown(
            SampleTests.ThrowArgumentNullExceptionTest);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void ExpectedExceptionIsNotThrown()
    {
        ExpectedException<ArgumentNullException>.AssertExceptionThrown(
            () => { });
    }
}