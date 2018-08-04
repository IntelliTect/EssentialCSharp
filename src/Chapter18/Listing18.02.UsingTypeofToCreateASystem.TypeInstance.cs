namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_02
{
    using System;
    using System.Diagnostics;

    public class Program
    {
        public static void Main()
        {
            ThreadPriorityLevel priority;
            priority = (ThreadPriorityLevel)Enum.Parse(
                    typeof(ThreadPriorityLevel), "Idle");
        }
    }
}