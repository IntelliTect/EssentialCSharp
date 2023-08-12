namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_09;

#region INCLUDE
using System;
using System.Reflection;
using System.Threading;

public class Program
{
    public static void Main()
    {
        // Obtain the mutex name from the full 
        // assembly name.
        string mutexName =
            Assembly.GetEntryAssembly()!.FullName!;

        // firstApplicationInstance indicates
        // whether this is the first
        // application instance.
        using Mutex mutex = new(false, mutexName,
             out bool firstApplicationInstance);

        if (!firstApplicationInstance)
        {
            Console.WriteLine(
                "This application is already running.");
        }
        else
        {
            Console.WriteLine("ENTER to shut down");
            Console.ReadLine();
        }
    }
}
#endregion INCLUDE
