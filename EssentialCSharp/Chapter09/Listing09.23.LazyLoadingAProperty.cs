namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_23
{
    using Listing09_22;
    using System.IO;

    class DataCache
    {
        // ...

        public TemporaryFileStream FileStream
        {
            get
            {
                if(_FileStream == null)
                {
                    _FileStream = new TemporaryFileStream();
                }
                return _FileStream;
            }
        }
        private TemporaryFileStream _FileStream = null;

        // ...
    }
}