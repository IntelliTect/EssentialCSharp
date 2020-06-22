namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_13
{
    using System;

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
