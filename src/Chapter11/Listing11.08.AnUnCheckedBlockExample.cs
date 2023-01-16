namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_08;

#region INCLUDE
using System;
public class Program
{
    public static void Main()
    {
        #region HIGHLIGHT
        unchecked
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
