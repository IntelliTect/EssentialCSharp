namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_12
{
    using System;
    using System.Diagnostics;

    public class Program
    {
        public static void Main()
        {
            #region INCLUDE
            ThreadPriorityLevel priority = (ThreadPriorityLevel)Enum.Parse(
                typeof(ThreadPriorityLevel), "Idle");
            Console.WriteLine(priority);
            #endregion INCLUDE
        }
    }
}
