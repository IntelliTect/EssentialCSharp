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
            ExpectedException<DivideByZeroException>.AssertExceptionThrown(
                () => { });
        }
        catch(InvalidOperationException exception)
        {
            Assert.IsTrue(exception.Message.Contains("'() => { }'"));
        }
    }

    [TestMethod]
    public void Method()
    {
        try
        {
            SampleTests.Method();
        }
        catch (InvalidOperationException exception)
        {
            Assert.IsTrue(
                exception.Message.Contains("'() => { }'") &&
                exception.Message.Contains("'Method'") &&
                exception.Message.Contains("'./FileName.cs'"));
            // The expected exception, System.DivideByZeroException,
            // was not thrown by the expression, 'Method' in the method, './FileName.cs', and file 'C:\Git\EssentialCSharp\src\Chapter18\Listing18.25b.CallerArgumentExpression.cs'.
        }
    }

    private object PassingMethodNameAndFileName()
    {
        throw new NotImplementedException();
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
