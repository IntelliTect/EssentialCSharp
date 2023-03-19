namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_07;

#region INCLUDE
using System;
public class Program
{
    public static void Main()
    {
        #region HIGHLIGHT
        checked
        {
        #endregion HIGHLIGHT
            // int.MaxValue equals 2147483647
            int n = int.MaxValue;
            n = n + 1;
            Console.WriteLine(n);
        #region HIGHLIGHT
        }
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
