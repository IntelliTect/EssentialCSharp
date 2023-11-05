namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_07;

#region INCLUDE
using System;
using System.Diagnostics;
using System.Threading;

public class Program
{
    private static Stopwatch Clock { get; } = new Stopwatch();

    public static void Main()
    {
        try
        {
            Clock.Start();
            #region HIGHLIGHT
            // Register a callback to receive notifications
            // of any unhandled exception

            AppDomain.CurrentDomain.UnhandledException +=
              (s, e) =>
              {
                  Message("Event handler starting");
                  Delay(4000);
              };
#endregion HIGHLIGHT
            Thread thread = new(() =>
            {
                Message("Throwing exception.");
                throw new Exception();
            });
            thread.Start();
            
            Delay(2000);
        }
        finally
        {
            Message("Finally block running.");
        }
    }

    static void Delay(int i)
    {
        Message($"Sleeping for {i} ms");
        Thread.Sleep(i);
        Message("Awake");
    }

    static void Message(string text)
    {
        Console.WriteLine("{0}:{1:0000}:{2}",
            Environment.CurrentManagedThreadId,
            Clock.ElapsedMilliseconds, text);
    }
}
#endregion INCLUDE
