namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_14
{
    using System;
    using System.Diagnostics;

    public class Program
    {
        public static void Main()
        {
            System.Diagnostics.ThreadPriorityLevel priority;
            if(Enum.TryParse("Idle", out priority))
            {
                Console.WriteLine(priority);
            }
        }
    }
}
