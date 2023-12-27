#pragma warning disable CS0168 // Variable is declared but never used
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_15;

#region INCLUDE

#region HIGHLIGHT
// 声明别名Timer来引用System.Timers.Timer，
// 以避免代码与System.Threading.Timer产生歧义。
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
