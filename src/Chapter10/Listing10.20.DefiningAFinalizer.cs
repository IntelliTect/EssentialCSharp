namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_20
{
    using System;
    using System.IO;

    public class TemporaryFileStream
    {
        public TemporaryFileStream(string fileName)
        {
            File = new FileInfo(fileName);
            Stream = new FileStream(
                File.FullName, FileMode.OpenOrCreate,
                FileAccess.ReadWrite);
        }

        public TemporaryFileStream()
            : this(Path.GetTempFileName())
        { }

        // Finalizer
        ~TemporaryFileStream()
        {
            Close();
        }

        public FileStream? Stream { get; private set; }
        public FileInfo? File { get; private set; }

        public void Close()
        {
            Stream?.Dispose();
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