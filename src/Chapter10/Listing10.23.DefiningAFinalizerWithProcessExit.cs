namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_23
{
    using System;
    using System.IO;

    public static class Program
    {
        // ...
        public static void Search()
        {
            TemporaryFileStream fileStream =
                new TemporaryFileStream();

            // Use temporary file stream
            // ...

            fileStream.Dispose();

            // ...
        }
    }

    class TemporaryFileStream : IDisposable
    {
        public TemporaryFileStream(string fileName)
        {
            File = new FileInfo(fileName);
            Stream = new FileStream(
                File.FullName, FileMode.OpenOrCreate,
                FileAccess.ReadWrite);

            var weakReferenceToSelf = new WeakReference<IDisposable>(this);
            ProcessExitHandler = (_, __) =>
            {
                if (weakReferenceToSelf.TryGetTarget(out IDisposable? self))
                {
                    self.Dispose();
                }
            };
            AppDomain.CurrentDomain.ProcessExit
                += ProcessExitHandler;
        }
        // Stores the process exit delegate so that we can remove it
        // if Dispose() or Finalize() is called already.
        private EventHandler ProcessExitHandler;

        public TemporaryFileStream()
            : this(Path.GetTempFileName()) { }

        ~TemporaryFileStream()
        {
            Dispose(false);
        }

        public FileStream? Stream { get; private set; }
        public FileInfo? File { get; private set; }

        #region IDisposable Members
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
        public void Dispose(bool disposing)
        {
            // Do not dispose of an owned managed object (one with a 
            // finalizer) if called by member finalize,
            // as the owned managed objects finalize method 
            // will be (or has been) called by finalization queue 
            // processing already
            if (disposing)
            {
                Stream?.Dispose();
                // Turn off calling the finalizer
                System.GC.SuppressFinalize(this);
            }
            AppDomain.CurrentDomain.ProcessExit -= ProcessExitHandler;
            try
            {
                File?.Delete();
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception);
            }
            Stream = null;
            File = null;
        }

    }
}