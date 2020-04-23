namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_06
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;

    public static class Program
    {
        static public async void Main(params string[] args)
        {
            string directoryPath = Directory.GetCurrentDirectory();
            string searchPattern = "*";
            switch (args?.Length)
            {
                case 1:
                    directoryPath = args[0];
                    break;
                case 2:
                    searchPattern = args[1];
                    break;
                default:
                    DisplayHelp();
                    break;
            }

            using Cryptographer cryptographer = new Cryptographer();

            IEnumerable<string> files = Directory.EnumerateFiles(
                directoryPath, searchPattern);

            // Create a cancellation token source to cancel 
            // if the operation takes more than a minute.
            using CancellationTokenSource cancellationTokenSource =
                new CancellationTokenSource(1000*60);

            await foreach ((string fileName, string encryptedFileName)
                in EncryptFilesAsync(files, cryptographer)
                .Zip(files.ToAsyncEnumerable())
                .WithCancellation(cancellationTokenSource.Token)
                )
            {
                Console.WriteLine($"{fileName}=>{encryptedFileName}");
            }

        }

        static public async IAsyncEnumerable<string> EncryptFilesAsync(
            IEnumerable<string> files, Cryptographer cryptographer,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            foreach (string fileName in files)
            {
                yield return await EncryptFileAsync(fileName, cryptographer);
                cancellationToken.ThrowIfCancellationRequested();
            }
        }

        private static async ValueTask<string> EncryptFileAsync(
            string fileName, Cryptographer cryptographer)
        {
            string encryptedFileName = $"{fileName}.encrypt";
            await using FileStream outputFileStream =
                new FileStream(encryptedFileName, FileMode.Create);

            string data = await File.ReadAllTextAsync(fileName);

            await cryptographer.EncryptAsync(data, outputFileStream);

            return encryptedFileName;
        }


        // Included to simplify testing
        public static Cryptographer? Cryptographer { get; private set; }

        private static void DisplayHelp() { /* ... */ }

    }
}
