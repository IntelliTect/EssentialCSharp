namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_07a;

#region INCLUDE
public class SampleTests
{
    [ExpectedException<DivideByZeroException>]
    public static void ThrowArgumentNullExceptionTest()
    {
        var result = 1/"".Length;
    }
}
#endregion INCLUDE

[AttributeUsage(AttributeTargets.Method)]
public class ExpectedException<TException> : Attribute where TException : Exception
{
    public static void AssertExceptionThrown(Action testMethod)
    {
        try
        {
            testMethod();
            throw new InvalidOperationException(
                $"The expected exception, {typeof(TException).FullName} was not thrown.");
        }
        catch (TException)
        {

        }
    }
}
