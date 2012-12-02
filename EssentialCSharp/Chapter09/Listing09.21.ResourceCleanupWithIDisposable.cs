namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_21
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

            // Use temporary file stream;
            // ...

            fileStream.Dispose();

            // ...
        }
    }

    class TemporaryFileStream : IDisposable
    {
        public TemporaryFileStream()
        {
            _File = new FileInfo(Path.GetTempFileName());
            _Stream = new FileStream(
                File.FullName, FileMode.OpenOrCreate,
                FileAccess.ReadWrite);
        }

        ~TemporaryFileStream()
        {
            Dispose(false);
        }

        public FileStream Stream
        {
            get { return _Stream; }
        }
        readonly private FileStream _Stream;

        public FileInfo File
        {
            get { return _File; }
        }
        readonly private FileInfo _File;

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
            // finalizer) if called by member finalize
            // as the owned managed objects finalize method 
            // will be (or has been) called by finalization queue 
            // processing already
            if(disposing)
            {
                if(Stream != null)
                {
                    Stream.Close();
                }
            }
            if(File != null)
            {
                File.Delete();
            }
        }
    }
}