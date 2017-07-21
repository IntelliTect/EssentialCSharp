namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_13
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            IEnumerable<Process> processes = Process.GetProcesses().Where(
                process => { return process.WorkingSet64 > 1000000000; });
        }
    }
}