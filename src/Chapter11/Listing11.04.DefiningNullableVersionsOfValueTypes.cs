namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_04
{
    using System;

    struct NullableInt
    {
        /// <summary>
        /// Provides the value when HasValue returns true.
        /// </summary>
        public int Value { get; private set; }

        /// <summary>
        /// Indicates whether there is a value or whether
        /// the value is "null".
        /// </summary>
        public bool HasValue { get; private set; }

        // ...
    }

    struct NullableGuid
    {
        /// <summary>
        /// Provides the value when HasValue returns true.
        /// </summary>
        public Guid Value { get; private set; }

        /// <summary>
        /// Indicates whether there is a value or whether
        /// the value is "null".
        /// </summary>
        public bool HasValue { get; private set; }

        // ...
    }

    // ...
}