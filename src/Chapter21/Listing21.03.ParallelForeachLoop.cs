namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_03;

using AddisonWesley.Michaelis.EssentialCSharp.Shared;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.IO;
#region HIGHLIGHT
using System.Threading.Tasks;
#endregion HIGHLIGHT

public class Program
{
    #region EXCLUDE
    public static void Main()
    {
        EncryptFiles(Directory.GetCurrentDirectory(), "*.*");
    }
    #endregion EXCLUDE
    public static void EncryptFiles(
        string directoryPath, string searchPattern)

    {
        IEnumerable<string> files = Directory.EnumerateFiles(
            directoryPath, searchPattern,
            SearchOption.AllDirectories);

        #region HIGHLIGHT
        Parallel.ForEach(files, fileName =>
        {
            Encrypt(fileName);
        });
        #endregion HIGHLIGHT
    }
    #region EXCLUDE
    public static string Encrypt(string fileName)
    {
        string outputFileName = $"{fileName}.encrypt";
        Encrypt(fileName, outputFileName);
        return outputFileName;
    }

    static Cryptographer Cryptographer { get; } = new Cryptographer();

    public static void Encrypt(string inputFileName, string outputFileName)
    {
        Console.WriteLine($">>>>>Encrypting '{ inputFileName }'.");
        using (FileStream outputFileStream = new($"{inputFileName}.encrypt", FileMode.Create))
        {
            byte[] encryptedText = Cryptographer.EncryptAsync(File.ReadAllText(inputFileName), outputFileStream).Result;
        }
        Console.WriteLine($"<<<<<Finished encrypting '{ inputFileName}'.");
    }

    public static void Decrypt(string inputFileName, string outputFileName)
    {
        Console.WriteLine($">>>>>Decrypting '{ inputFileName }'.");
        byte[] bytes = File.ReadAllBytes(inputFileName);
        using (FileStream outputFileStream = new(outputFileName, FileMode.Create))
        {
            Cryptographer.DecryptAsync(bytes, outputFileStream).Wait();
        }
        Console.WriteLine($"<<<<<Finished decrypting '{ inputFileName}'.");
    }
    #endregion EXCLUDE
}
#endregion INCLUDE





