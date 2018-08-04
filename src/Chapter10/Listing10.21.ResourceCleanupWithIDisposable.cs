namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_21
{
    using System;
    using System.IO;

    public class Program
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

        public FileStream Stream { get; }
        public FileInfo File { get; }

        public void Close()
        {
            Dispose();
        }

        #region IDisposable Members
        public void Dispose()
        {
            Dispose(true);

            // Turn off calling the finalizer
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
            File?.Delete();
        }

    }
}