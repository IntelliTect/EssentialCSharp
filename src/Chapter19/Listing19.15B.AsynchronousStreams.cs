namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15B
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;

    public class Program
    {
        static public async void Main()
        {
            // Create a cancellation token source to cancel 
            // if the operation takes more than a minute.
            using CancellationTokenSource cancellationTokenSource =
                new CancellationTokenSource(1000 * 60);

            try
            {
                await foreach (string fileName in
                    EncryptFilesAsync()
                        .WithCancellation(cancellationTokenSource.Token))
                {
                    Console.WriteLine(fileName);
                }
            }
            finally
            {
                Cryptographer?.Dispose();
            }
        }

        static public async IAsyncEnumerable<string> EncryptFilesAsync(
            string? directoryPath = null, string searchPattern = "*",
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(
                directoryPath ?? Directory.GetCurrentDirectory(), searchPattern,
                SearchOption.AllDirectories);

            foreach (string fileName in files)
            {
                string encryptedFileName = $"{fileName}.encrypt";
                await using FileStream outputFileStream =
                    new FileStream(encryptedFileName, FileMode.Create);
                
                string data = await File.ReadAllTextAsync(fileName);

                await Cryptographer.EncryptAsync(data, outputFileStream);

                yield return encryptedFileName;

                cancellationToken.ThrowIfCancellationRequested();
                
            }
        }

        // ...

        static public Cryptographer Cryptographer { get; } = new Cryptographer();

    }
}