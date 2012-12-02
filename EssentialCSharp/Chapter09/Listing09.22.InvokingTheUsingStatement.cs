namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_22
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Search()
        {
            using(TemporaryFileStream fileStream1 =
                new TemporaryFileStream(),
                fileStream2 = new TemporaryFileStream())
            {
                // Use temporary file stream;
            }
        }
    }

    class TemporaryFileStream : IDisposable
    {
        public TemporaryFileStream(string fileName)
        {
            _File = new FileInfo(fileName);
            _Stream = new FileStream(
                File.FullName, FileMode.OpenOrCreate,
                FileAccess.ReadWrite);
        }
        public TemporaryFileStream()
            : this(Path.GetTempFileName()) { }

        ~TemporaryFileStream()
        {
            Close();
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
            if(Stream != null)
            {
                Stream.Close();
            }
            if(File != null)
            {
                File.Delete();
            }
            // Turn off calling the finalizer
            System.GC.SuppressFinalize(this);
        }

        #region IDisposable Members
        public void Dispose()
        {
            Close();
        }
        #endregion
    }
}