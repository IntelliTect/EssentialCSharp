namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_07;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
#region INCLUDE
public class AsyncEncryptionCollection : IAsyncEnumerable<string>
{
    public async IAsyncEnumerator<string> GetAsyncEnumerator(
        CancellationToken cancellationToken = default)
    {
        #region EXCLUDE
        // Mock code
        yield return await Task<string>.Run(() => (string)"<filename>");
        #endregion EXCLUDE
    }

    public static async Task Main()
    {
        AsyncEncryptionCollection collection =
            new();
        // ...

        await foreach (string fileName in collection)
        {
            Console.WriteLine(fileName);
        }
    }
}
#endregion INCLUDE
