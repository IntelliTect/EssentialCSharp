using AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_27;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_28;

#if NET7_0_OR_GREATER
public class Program
{
    public static void Main()
    {
        #region INCLUDE
        ExpectedException<DivideByZeroException>.AssertExceptionThrown(
            () => throw new DivideByZeroException());
        #endregion INCLUDE
    }
}
#endif // NET7_0_OR_GREATER
