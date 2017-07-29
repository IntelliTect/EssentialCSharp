namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_13
{
    using System;
    using System.Diagnostics;

    public class Program
    {
        public static void Main()
        {
            ThreadPriorityLevel priority = (ThreadPriorityLevel)Enum.Parse(
                typeof(ThreadPriorityLevel), "Idle");
            Console.WriteLine(priority);
        }
    }
}
