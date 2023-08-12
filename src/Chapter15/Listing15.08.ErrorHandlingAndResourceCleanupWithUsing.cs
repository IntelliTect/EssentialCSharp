namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_08;

using System;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        System.Collections.Generic.Stack<int> stack = new();
        int number;

        #region HIGHLIGHT
        using (
            System.Collections.Generic.Stack<int>.Enumerator
                enumerator = stack.GetEnumerator())
        #endregion HIGHLIGHT
        {
            while (enumerator.MoveNext())
            {
                number = enumerator.Current;
                Console.WriteLine(number);
            }
        }
        #endregion INCLUDE
    }
}
