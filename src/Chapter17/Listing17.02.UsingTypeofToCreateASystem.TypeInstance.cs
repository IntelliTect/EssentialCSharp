namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_02
{
    using System;
    using System.Diagnostics;

    public class Program
    {
        public static void ChapterMain()
        {
            ThreadPriorityLevel priority;
            priority = (ThreadPriorityLevel)Enum.Parse(
                    typeof(ThreadPriorityLevel), "Idle");
        }
    }
}