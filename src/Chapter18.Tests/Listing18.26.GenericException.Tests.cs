
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_26.Tests;

#if NET7_0_OR_GREATER
[TestClass]
public class GenericExceptionTests
{
    [TestMethod]
    public void ExpectedExceptionIsThrown()
    {
        ExpectedException<DivideByZeroException>.AssertExceptionThrown(
            SampleTests.ThrowDivideByZeroExceptionTest);
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
