#pragma warning disable CS0168 // Variable is declared but never used
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_14;

#region INCLUDE
#region HIGHLIGHT
using CountDownTimer = System.Timers.Timer;
#if NET8_0_OR_GREATER // EXCLUDE
using StartStop = (DateTime Start, DateTime Stop);
#endif // NET8_0_OR_GREATER // EXCLUDE
#endregion HIGHLIGHT

public class HelloWorld
{
    public static void Main()
    {
        #region HIGHLIGHT
        CountDownTimer timer;
        #if NET8_0_OR_GREATER // EXCLUDE
        StartStop startStop;
        #endif // NET8_0_OR_GREATER // EXCLUDE
        #endregion HIGHLIGHT

        // ...
    }
}
#endregion INCLUDE
