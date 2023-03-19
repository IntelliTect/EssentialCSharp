namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_14;

#region INCLUDE
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

#region EXCLUDE
public class Program
{
    public static void Main()
    {
#endregion EXCLUDE
    IEnumerable<Process> processes = Process.GetProcesses().Where(
        process => { return process.WorkingSet64 > 1000000000; });
    // ...
#endregion INCLUDE
    }
}