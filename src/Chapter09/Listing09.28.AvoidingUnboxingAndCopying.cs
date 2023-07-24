namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_28;

using System;
public class Program
{
    public static void Main()
    {
        #region INCLUDE
        int number;
        object thing;
        number = 42;
        // Boxing
        thing = number;
        #region HIGHLIGHT
        // No unboxing conversion
        #endregion HIGHLIGHT
        string text = ((IFormattable)thing).ToString(
            "X", null);
        Console.WriteLine(text);
        #endregion INCLUDE
    }
}
