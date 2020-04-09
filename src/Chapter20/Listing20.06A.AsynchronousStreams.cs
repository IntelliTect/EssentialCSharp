namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_05
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;

class AsyncEncryptionCollection : IAsyncEnumerable<string?>
{
    public async IAsyncEnumerator<string?> GetAsyncEnumerator(
        CancellationToken cancellationToken = default)
    {
        yield return await Task<string>.Run(() => (string?)null);
    }

    static public async void Main()
    {
        AsyncEncryptionCollection collection =
            new AsyncEncryptionCollection();
        // ...

        await foreach (string? fileName in collection)
        {
            Console.WriteLine(fileName);
        }
    }
}
}
