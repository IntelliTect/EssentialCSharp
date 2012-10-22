namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_24
{
    using Listing09_22;
    using System.IO;
    using System;

    class DataCache
    {
        // ...

        public string FileStreamName { get; set; }

        public DataCache()
        {
            _FileStream = new Lazy<TemporaryFileStream>(
                () => new TemporaryFileStream(FileStreamName));
        }

        public TemporaryFileStream FileStream
        {
            get
            {
                return _FileStream.Value;
            }
        }
        private Lazy<TemporaryFileStream> _FileStream;

        // ...
    }
}