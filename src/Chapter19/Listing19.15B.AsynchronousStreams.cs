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

            IEnumerable<string> files = Directory.EnumerateFiles(
                directoryPath ?? Directory.GetCurrentDirectory(), searchPattern);

            // Create a cancellation token source to cancel 
            // if the operation takes more than a minute.
            using CancellationTokenSource cancellationTokenSource =
                new CancellationTokenSource(1);
            
            try
            {

                await foreach((string fileName, string encryptedFileName)
                    in EncryptFilesAsync(files).Zip(files.ToAsyncEnumerable()))
                {
                    Console.WriteLine($"{fileName}=>{encryptedFileName}");
                }
            }
            finally
            {
                Cryptographer?.Dispose();
            }
            
        }

        static public async IAsyncEnumerable<string> EncryptFilesAsync(
            IEnumerable<string> files,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {

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

        private static void DisplayHelp() { /* ... */ }

    }
}