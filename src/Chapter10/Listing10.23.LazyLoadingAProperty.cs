﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_23
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_21;

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

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_23_PreCSharp6
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_21;

#pragma warning disable CA1001 // A completed implementation would have be disposable

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

#pragma warning restore CA1001 // A completed implementation would have be disposable
}