namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_10;

#region INCLUDE
using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    #region EXCLUDE
    // Justification: Initialized at the start of Main.
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    #endregion EXCLUDE
    static ManualResetEventSlim _MainSignaledResetEvent;
    static ManualResetEventSlim _DoWorkSignaledResetEvent;
    #region EXCLUDE
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    #endregion EXCLUDE

    public static void DoWork()
    {
        Console.WriteLine("DoWork() started....");
        #region HIGHLIGHT
        _DoWorkSignaledResetEvent.Set();
        _MainSignaledResetEvent.Wait();
        #endregion HIGHLIGHT
        Console.WriteLine("DoWork() ending....");
    }

    public static void Main()
    {
        using(_MainSignaledResetEvent = new ())
        using(_DoWorkSignaledResetEvent = new ())
        {
            Console.WriteLine(
                "Application started....");
            Console.WriteLine("Starting task....");

            // Use Task.Factory.StartNew for .NET 4.0
            Task task = Task.Run(() => DoWork());

            // Block until DoWork() has started
            _DoWorkSignaledResetEvent.Wait();
            Console.WriteLine(
                "Waiting while task executes...");
            _MainSignaledResetEvent.Set();
            task.Wait();
            Console.WriteLine("Task completed");
            Console.WriteLine(
                "Application shutting down....");
        }
    }
}
#endregion INCLUDE
