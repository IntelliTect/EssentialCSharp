namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_19
{
    using Listing10_15;
    #region INCLUDE
    class DataCache
    {
        // ...

        public TemporaryFileStream FileStream =>
            InternalFileStream ??= 
                new TemporaryFileStream();

        private TemporaryFileStream? InternalFileStream
            { get; set; } = null;


        // ...
    }
    #endregion INCLUDE
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_18_PRECSHARP6
{
    using Listing10_15;

    class DataCache
    {
        // ...

        public TemporaryFileStream FileStream
        {
            get
            {
                _FileStream ??= new TemporaryFileStream();
                return _FileStream;
            }
        }
        private TemporaryFileStream? _FileStream = null;

        // ...
    }
}
