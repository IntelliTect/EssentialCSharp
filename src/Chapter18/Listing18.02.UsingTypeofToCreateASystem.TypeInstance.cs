namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_02
{
    using System;
    #region INCLUDE
    using System.Diagnostics;
    #region EXCLUDE
    public class Program
    {
        public static void Main()
        {
            #endregion EXCLUDE
            ThreadPriorityLevel priority;
            priority = (ThreadPriorityLevel)Enum.Parse(
                    typeof(ThreadPriorityLevel), "Idle");
            //...
            #endregion INCLUDE
        }
    }
}