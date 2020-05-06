namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_25
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_21;
    using System;

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
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_24_PreCSharp6
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_21;
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
        private Lazy<TemporaryFileStream> _FileStream;

        // ...
    }
}