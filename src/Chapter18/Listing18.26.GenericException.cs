namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_26;

#if NET7_0_OR_GREATER
#region INCLUDE
public class SampleTests
{
    #region HIGHLIGHT
    [ExpectedException<DivideByZeroException>]
    #endregion HIGHLIGHT
    public static void ThrowDivideByZeroExceptionTest()
    {
        var result = 1/"".Length;
    }
}

[AttributeUsage(AttributeTargets.Method)]
#region HIGHLIGHT
public class ExpectedException<TException> : 
    Attribute where TException : Exception
#endregion HIGHLIGHT
{
    public static TException AssertExceptionThrown(Action testMethod)
    {
        try
        {
            testMethod();
            throw new InvalidOperationException(
                $"The expected exception, {
                    typeof(TException).FullName }, was not thrown.");
        }
        catch (TException exception) 
        {
            return exception;
        }
    }

    // Attribute detection
    // ...
}
#endregion INCLUDE
#endif // NET7_0_OR_GREATER
