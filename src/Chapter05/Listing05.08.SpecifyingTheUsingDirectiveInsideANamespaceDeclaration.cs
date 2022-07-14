#region INCLUDE
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_08
{
    #region HIGHLIGHT
    using System;
    #endregion HIGHLIGHT

    public class HelloWorld
    {
        public static void Main()
        {
            // No need to qualify Console with System
            // because of the using directive above
            #region HIGHLIGHT
            Console.WriteLine("Hello, my name is Inigo Montoya");
            #endregion HIGHLIGHT
        }
    }
}
#endregion INCLUDE