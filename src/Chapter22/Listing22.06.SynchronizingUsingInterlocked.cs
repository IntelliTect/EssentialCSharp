// Justification: Only partial implementation provided.
#pragma warning disable IDE0051 // Remove unused private members

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_06
{
    using System.Threading;

    class SynchronizationUsingInterlocked
    {
        private static object? _Data;

        // Initialize data if not yet assigned
        static void Initialize(object newValue)
        {
            // If _Data is null then set it to newValue
            Interlocked.CompareExchange(
                ref _Data, newValue, null);
        }

        // ...
    }
}
