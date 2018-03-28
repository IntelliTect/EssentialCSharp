namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_28
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

        static void EncryptFiles(
            string directoryPath, string searchPattern)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(
                directoryPath, searchPattern,
                SearchOption.AllDirectories);

            Parallel.ForEach(files, (fileName) =>
            {
                Encrypt(fileName);
            });
        }

        // ...

        private static void Encrypt(string fileName)
        {
            if (Path.GetExtension(fileName) == ".encrypt") return;
            Console.WriteLine($">>>>>Encrypting '{ fileName }'.");
            Cryptographer cryptographer = new Cryptographer();
            File.Delete($"{fileName}.encrypt");
            byte[] encryptedText = cryptographer.Encrypt(File.ReadAllBytes(fileName));
            File.WriteAllBytes($"{fileName}.encrypt", encryptedText);
            Console.WriteLine($"<<<<<Finished encrypting '{ fileName}'.");
        }

    }

}





