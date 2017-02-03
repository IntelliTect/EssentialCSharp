namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_05
{
    struct Nullable
    {
        /// <summary>
        /// Provides the value when HasValue returns true.
        /// </summary>
        public object Value { get; private set; }

        /// <summary>
        /// Indicates whether there is a value or whether
        /// the value is "null".
        /// </summary>
        public bool HasValue { get; private set; }

        // ...
    }
}