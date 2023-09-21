using System.Runtime.CompilerServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_27;

#if NET7_0_OR_GREATER
#region INCLUDE
public class SampleTests
{
    #region HIGHLIGHT
    [ExpectedException<DivideByZeroException>]
    #endregion HIGHLIGHT
    public static void ThrowArgumentNullExceptionTest()
    {
        var result = 1/"".Length;
    }
}

[AttributeUsage(AttributeTargets.Method)]
public class ExpectedException<TException> : 
    Attribute where TException : Exception
{
    #region HIGHLIGHT
    public static TException AssertExceptionThrown(
        Action testAction,
        [CallerArgumentExpression(nameof(testAction))]
            string testExpression = null!,
        [CallerMemberName]string testActionMemberName = null!,
        [CallerFilePath]string testActionFileName = null!
        )
    #endregion HIGHLIGHT
    {
        try
        {
            testAction();
            throw new InvalidOperationException(
                $"The expected exception, {
                    typeof(TException).FullName }, was not thrown" +
                    $" by the expression '{
                        testExpression }' in the method '{
                        testActionMemberName }' and file '{
                        testActionFileName }'.");
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
