namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_03
{
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            EncryptFiles(Directory.GetCurrentDirectory(), "*.*");
        }

        static public void EncryptFiles(
            string directoryPath, string searchPattern)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(
                directoryPath, searchPattern,
                SearchOption.AllDirectories);

            Parallel.ForEach(files, fileName =>
            {
                Encrypt(fileName);
            });
        }

        // ...

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
            using (FileStream outputFileStream = new FileStream($"{inputFileName}.encrypt", FileMode.Create))
            {
                byte[] encryptedText = Cryptographer.EncryptAsync(File.ReadAllText(inputFileName), outputFileStream).Result;
            }
            Console.WriteLine($"<<<<<Finished encrypting '{ inputFileName}'.");
        }

        public static void Decrypt(string inputFileName, string outputFileName)
        {
            Console.WriteLine($">>>>>Decrypting '{ inputFileName }'.");
            byte[] bytes = File.ReadAllBytes(inputFileName);
            using (FileStream outputFileStream = new FileStream(outputFileName, FileMode.Create))
            {
                Cryptographer.DecryptAsync(bytes, outputFileStream).Wait();
            }
            Console.WriteLine($"<<<<<Finished decrypting '{ inputFileName}'.");
        }

    }




}





