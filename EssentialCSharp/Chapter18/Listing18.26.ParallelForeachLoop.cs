namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_26
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    class Program
    {
        // ...
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
            // ...

            throw new NotImplementedException();
        }

    }

}





