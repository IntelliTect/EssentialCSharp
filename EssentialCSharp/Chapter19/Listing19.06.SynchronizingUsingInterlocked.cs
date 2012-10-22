namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_06
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    class SynchronizationUsingInterlocked
    {
        private static object _Data;

        // Initialize data if not yet assigned.
        static void Initialize(object newValue)
        {
            // If _Data is null then set it to newValue.
            Interlocked.CompareExchange(
                ref _Data, newValue, null);
        }

        // ...
    }
}
