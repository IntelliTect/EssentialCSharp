namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_05;

using AddisonWesley.Michaelis.EssentialCSharp.Shared;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    #region EXCLUDE
    public static void Main()
    {
        EncryptFiles($@"{Directory.GetCurrentDirectory()}\..\..\", "*.*");
    }
    #endregion EXCLUDE

    static void EncryptFiles(
        string directoryPath, string searchPattern)
    {

        string stars =
            "*".PadRight(Console.WindowWidth - 1, '*');

        IEnumerable<string> files = Directory.GetFiles(
           directoryPath, searchPattern,
           SearchOption.AllDirectories);

        #region HIGHLIGHT
        CancellationTokenSource cts = new();
        ParallelOptions parallelOptions = new()
            { CancellationToken = cts.Token };
        cts.Token.Register(
            () => Console.WriteLine("Canceling..."));
        #endregion HIGHLIGHT

        Console.WriteLine("Press ENTER to exit.");

        Task task = Task.Run(() =>
            {
                try
                {
                    Parallel.ForEach(
                    #region HIGHLIGHT
                        files, parallelOptions,
                    #endregion HIGHLIGHT
                        (fileName, loopState) =>
                        {
                            Encrypt(fileName);
                        });
                }
                catch(OperationCanceledException) { }
            });

        // Wait for the user's input
        Console.ReadLine();

        // Cancel the query
        #region HIGHLIGHT
        cts.Cancel();
        #endregion HIGHLIGHT
        Console.Write(stars);
        task.Wait();
    }
    #region EXCLUDE

    private static void Encrypt(string fileName)
    {
        if (Path.GetExtension(fileName) == ".encrypt") return;
        Console.WriteLine($">>>>>Encrypting '{ fileName }'.");
        Cryptographer cryptographer = new();
        File.Delete($"{fileName}.encrypt");
        byte[] encryptedText = cryptographer.Encrypt(File.ReadAllText(fileName));
        File.WriteAllBytes($"{fileName}.encrypt", encryptedText);
        Console.WriteLine($"<<<<<Finished encrypting '{ fileName}'.");
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
