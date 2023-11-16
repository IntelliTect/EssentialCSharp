namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_28.Tests;

#if NET7_0_OR_GREATER
[TestClass]
public class GenericExceptionTests
{
    [TestMethod]
    public void Method()
    {
        try
        {
            Program.Main();
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
}
#endif // NET7_0_OR_GREATER
