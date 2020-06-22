namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_05
{
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            EncryptFiles($@"{Directory.GetCurrentDirectory()}\..\..\", "*.*");
        }

        static void EncryptFiles(
            string directoryPath, string searchPattern)
        {

            string stars =
                "*".PadRight(Console.WindowWidth - 1, '*');

            IEnumerable<string> files = Directory.GetFiles(
               directoryPath, searchPattern,
               SearchOption.AllDirectories);

            CancellationTokenSource cts =
                new CancellationTokenSource();
            ParallelOptions parallelOptions =
                new ParallelOptions { CancellationToken = cts.Token };
            cts.Token.Register(
                () => Console.WriteLine("Canceling..."));

            Console.WriteLine("Press ENTER to exit.");

            // Use Task.Factory.StartNew<string>() for
            // TPL prior to .NET 4.5
            Task task = Task.Run(() =>
                {
                    try
                    {
                        Parallel.ForEach(
                            files, parallelOptions,
                            (fileName, loopState) =>
                            {
                                Encrypt(fileName);
                            });
                    }
                    catch(OperationCanceledException) { }
                });

            // Wait for the user's input
            Console.Read();

            // Cancel the query
            cts.Cancel();
            Console.Write(stars);
            task.Wait();
        }

        private static void Encrypt(string fileName)
        {
            if (Path.GetExtension(fileName) == ".encrypt") return;
            Console.WriteLine($">>>>>Encrypting '{ fileName }'.");
            Cryptographer cryptographer = new Cryptographer();
            File.Delete($"{fileName}.encrypt");
            byte[] encryptedText = cryptographer.Encrypt(File.ReadAllText(fileName));
            File.WriteAllBytes($"{fileName}.encrypt", encryptedText);
            Console.WriteLine($"<<<<<Finished encrypting '{ fileName}'.");
        }
    }
}


