namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_18;

using System;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        System.Diagnostics.ThreadPriorityLevel priority;
        if(Enum.TryParse("Idle", out priority))
        {
            Console.WriteLine(priority);
        }
        #endregion INCLUDE
    }
}
