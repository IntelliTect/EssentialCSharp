namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_21
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
        }

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

            //unregister from the finalization queue.
            System.GC.SuppressFinalize(this);
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
            }
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