namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_20
{
    using System.IO;

    class TemporaryFileStream
    {
        public TemporaryFileStream()
        {
            _File = new FileInfo(Path.GetTempFileName());
            _Stream = new FileStream(
                File.FullName, FileMode.OpenOrCreate,
                FileAccess.ReadWrite);
        }

        // Finalizer
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
        readonly private FileInfo _File =
            new FileInfo(Path.GetTempFileName());

        public void Close()
        {
            if (Stream != null)
            {
                Stream.Close();
            }
            if (File != null)
            {
                File.Delete();
            }
        }
    }
}