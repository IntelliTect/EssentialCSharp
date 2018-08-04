namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_10
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using System.Threading;

    class Program
    {
        static void EncryptFiles(
            string directoryPath, string searchPattern)
        {
            IEnumerable<string> files = Directory.GetFiles(
                directoryPath, searchPattern,
                SearchOption.AllDirectories);

            Parallel.ForEach(files, (fileName) =>
            {
                Encrypt(fileName);
            });
        }

        private static void Encrypt(string fileName)
        {
            if (Path.GetExtension(fileName) == ".encrypt") return;
            Console.WriteLine($">>>>>Encrypting '{ fileName }'.");
            Shared.Cryptographer cryptographer = new Shared.Cryptographer();
            File.Delete($"{fileName}.encrypt");
            byte[] encryptedText = cryptographer.Encrypt(File.ReadAllBytes(fileName));
            File.WriteAllBytes($"{fileName}.encrypt", encryptedText);
            Console.WriteLine($"<<<<<Finished encrypting '{ fileName}'.");
        }

        public static void Main()
        {
            int numberOfFiles = Directory.GetFiles(Directory.GetCurrentDirectory()).Length;
            DateTime timeBefore = DateTime.Now;
            EncryptFiles(Directory.GetCurrentDirectory(), "*");
            DateTime timeAfter = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(
                "There were {0} file(s) in the directory which should have taken {0} second(s) to encrypt synchronously. The actual time taken was {1} second(s).",
                numberOfFiles, (timeAfter - timeBefore).TotalSeconds);
            Console.WriteLine();
        }
    }

}
