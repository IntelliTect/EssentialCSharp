#pragma warning disable CS0168 // Variable is declared but never used
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_11
{
    #region INCLUDE

    #region HIGHLIGHT
    // Declare alias Timer to refer to System.Timers.Timer to
    // avoid code ambiguity with System.Threading.Timer
    using Timer = System.Timers.Timer;
    #endregion

    public class HelloWorld
    {
        public static void Main()
        {
            #region HIGHLIGHT
            Timer timer;
            #endregion

            // ...
        }
    }
    #endregion
}
