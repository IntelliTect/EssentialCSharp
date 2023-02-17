namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_20
{
    using Listing10_15;
    using System;
    #region INCLUDE
    class DataCache
    {
        // ...

        public TemporaryFileStream FileStream => 
            InternalFileStream.Value;
        private Lazy<TemporaryFileStream> InternalFileStream { get; }
            = new Lazy<TemporaryFileStream>( 
                () => new TemporaryFileStream() );

        // ...
    }
    #endregion INCLUDE
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_19_Listing10_18_PRECSHARP6
{
    using Listing10_15;
    using System;

    class DataCache
    {
        // ...

        public DataCache()
        {
            _FileStream = new Lazy<TemporaryFileStream>(
                () => new TemporaryFileStream());
        }

        public TemporaryFileStream FileStream
        {
            get
            {
                return _FileStream.Value;
            }
        }
        private readonly Lazy<TemporaryFileStream> _FileStream;

        // ...
    }
}
