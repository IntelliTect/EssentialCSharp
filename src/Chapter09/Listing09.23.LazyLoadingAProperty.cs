namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_23
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_21;

    class DataCache
    {
        // ...

        public TemporaryFileStream FileStream =>
            InternalFileStream??(InternalFileStream = 
                new TemporaryFileStream());

        private TemporaryFileStream InternalFileStream
            { get; set; } = null;


        // ...
    }
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_23_PreCSharp6
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_21;

    class DataCache
    {
        // ...

        public TemporaryFileStream FileStream
        {
            get
            {
                if (_FileStream == null)
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