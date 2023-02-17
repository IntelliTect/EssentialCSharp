namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_18
{
    using System;
    #region INCLUDE
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static ConsoleLogger;

    public static class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Starting...");
            DoStuff();
            if (args.Any(arg => arg.ToLower() == "-gc"))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            WriteLine("Exiting...");
        }

        public static void DoStuff()
        {
            // ...
            
            WriteLine("Starting...");
            SampleUnmanagedResource? sampleUnmanagedResource = null;

            try
            {
                sampleUnmanagedResource =
                    new SampleUnmanagedResource();
                // Use unmanaged Resource
                // ...
            }
            finally
            {
                if (Environment.GetCommandLineArgs().Any(
                arg => arg.ToLower() == "-dispose"))
                {
                    sampleUnmanagedResource?.Dispose();
                }
            }

            WriteLine("Exiting...");

            // ...
        }
    }

    class SampleUnmanagedResource : IDisposable
    {
        public SampleUnmanagedResource(string fileName)
        {
            WriteLine("Starting...",
                $"{nameof(SampleUnmanagedResource)}.ctor");

            WriteLine("Creating managed stuff...",
                $"{nameof(SampleUnmanagedResource)}.ctor");
            WriteLine("Creating unmanaged stuff...",
                $"{nameof(SampleUnmanagedResource)}.ctor");

            WeakReference<IDisposable> weakReferenceToSelf =
                 new(this);
            ProcessExitHandler = (_, __) =>
            {
                WriteLine("Starting...", "ProcessExitHandler");
                if (weakReferenceToSelf.TryGetTarget(
                    out IDisposable? self))
                {
                    self.Dispose();
                }
                WriteLine("Exiting...", "ProcessExitHandler");
            };
            AppDomain.CurrentDomain.ProcessExit
                += ProcessExitHandler;
            WriteLine("Exiting...",
                $"{nameof(SampleUnmanagedResource)}.ctor");
        }

        // Stores the process exit delegate so that we can remove it
        // if Dispose() or Finalize() is called already.
        private EventHandler ProcessExitHandler { get; }

        public SampleUnmanagedResource()
            : this(Path.GetTempFileName()) { }

        ~SampleUnmanagedResource()
        {
            WriteLine("Starting...");
            Dispose(false);
            WriteLine("Exiting...");
        }

        public void Dispose()
        {
            Dispose(true);
            #region EXCLUDE
            // Request that the finalizer not be called for this object.
            GC.SuppressFinalize(this);
            #endregion EXCLUDE
        }

        public void Dispose(bool disposing)
        {
            WriteLine("Starting...");

            // Do not dispose of an owned managed object (one with a 
            // finalizer) if called by member finalize,
            // as the owned managed objects finalize method 
            // will be (or has been) called by finalization queue 
            // processing already
            if (disposing)
            {
                WriteLine("Disposing managed stuff...");
            }

            AppDomain.CurrentDomain.ProcessExit -=
                ProcessExitHandler;

            WriteLine("Disposing unmanaged stuff...");

            WriteLine("Exiting...");
        }
    }
    #endregion INCLUDE

    public static class ConsoleLogger
    {
        public static void WriteLine(string? message = null, [CallerMemberName] string? name = null)
            => Console.WriteLine($"{$"{name}: " }{ message ?? ": Executing" }");
    }
}
