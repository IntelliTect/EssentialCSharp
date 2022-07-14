#pragma warning disable CS0168 // Variable is declared but never used
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_11
{
    #region INCLUDE
    using System;
    using System.Threading;

    #region HIGHLIGHT
    // Declare alias Timer to refer to System.Timers.Timer to
    // avoid code ambiguity with System.Threading.Timer
    using Timer = System.Timers.Timer;
    #endregion HIGHLIGHT

    public class HelloWorld
    {
        public static void Main()
        {
            #region HIGHLIGHT
            Timer timer;
            #endregion HIGHLIGHT

            // ...
        }
    }
    #endregion INCLUDE
}
