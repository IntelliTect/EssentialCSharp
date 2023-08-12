namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_06;

using System;
#region INCLUDE
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.CompilerServices;
using AddisonWesley.Michaelis.EssentialCSharp.Shared;

public static class Program
{
    public static async void Main(params string[] args)
    {
        string directoryPath = Directory.GetCurrentDirectory();
        string searchPattern = "*";
        #region EXCLUDE
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
        #endregion EXCLUDE
        using Cryptographer cryptographer = new();

        IEnumerable<string> files = Directory.EnumerateFiles(
            directoryPath, searchPattern);

        // Create a cancellation token source to cancel 
        // if the operation takes more than a minute.
        using CancellationTokenSource cancellationTokenSource =
            new(1000*60);

        #region HIGHLIGHT
        await foreach ((string fileName, string encryptedFileName)
            in EncryptFilesAsync(files, cryptographer)
            .Zip(files.ToAsyncEnumerable())
            .WithCancellation(cancellationTokenSource.Token)
            )
        #endregion HIGHLIGHT
        {
            Console.WriteLine($"{fileName}=>{encryptedFileName}");
        }
    }

    #region HIGHLIGHT
    public static async IAsyncEnumerable<string> EncryptFilesAsync(
        IEnumerable<string> files, Cryptographer cryptographer,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    #endregion HIGHLIGHT
    {
        foreach (string fileName in files)
        {
            #region HIGHLIGHT
            yield return await EncryptFileAsync(fileName, cryptographer);
            #endregion HIGHLIGHT
            cancellationToken.ThrowIfCancellationRequested();
        }
    }

    #region HIGHLIGHT
    private static async ValueTask<string> EncryptFileAsync(
        string fileName, Cryptographer cryptographer)
    #endregion HIGHLIGHT
    {
        string encryptedFileName = $"{fileName}.encrypt";
        #region HIGHLIGHT
        await using FileStream outputFileStream =
            new(encryptedFileName, FileMode.Create);
        #endregion HIGHLIGHT

        #region HIGHLIGHT
        string data = await File.ReadAllTextAsync(fileName);

        await cryptographer.EncryptAsync(data, outputFileStream);
        #endregion HIGHLIGHT

        return encryptedFileName;
    }
    #region EXCLUDE

    // Included to simplify testing
    public static Cryptographer? Cryptographer { get; private set; }

    private static void DisplayHelp() { /* ... */ }
    #endregion EXCLUDE
}
#endregion INCLUDE
