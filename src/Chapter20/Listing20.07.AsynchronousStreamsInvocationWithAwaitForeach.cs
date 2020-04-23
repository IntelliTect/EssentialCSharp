namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_07
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    class AsyncEncryptionCollection : IAsyncEnumerable<string>
    {
        public async IAsyncEnumerator<string> GetAsyncEnumerator(
            CancellationToken cancellationToken = default)
        {
            // Mock code
            yield return await Task<string>.Run(() => (string)"<filename>");
        }

        static public async void Main()
        {
            AsyncEncryptionCollection collection =
                new AsyncEncryptionCollection();
            // ...

            await foreach (string fileName in collection)
            {
                Console.WriteLine(fileName);
            }
        }
    }
}
