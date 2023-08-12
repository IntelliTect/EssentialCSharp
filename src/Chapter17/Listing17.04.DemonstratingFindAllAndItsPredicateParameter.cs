namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_04;

#region INCLUDE
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> list = new();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(2);

        #region HIGHLIGHT
        List<int> results = list.FindAll(Even);
        #endregion HIGHLIGHT

        #region HIGHLIGHT
        foreach (int number in results)
        #endregion HIGHLIGHT
        {
            Console.WriteLine(number);
        }
    }
    public static bool Even(int value) =>
        (value % 2) == 0;
}
#endregion INCLUDE
