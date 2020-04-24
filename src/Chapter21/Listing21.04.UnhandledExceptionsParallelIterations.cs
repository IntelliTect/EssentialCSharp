namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_04
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    public static class Program
    {
        public static void Main()
        {
            EncryptFiles(Directory.GetCurrentDirectory(), "*.*");
        }
        // ...
        static void EncryptFiles(
            string directoryPath, string searchPattern)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(
                directoryPath, searchPattern,
                SearchOption.AllDirectories);
            try
            {
                Parallel.ForEach(files, fileName =>
                {
                    Encrypt(fileName);
                });
            }
            catch(AggregateException exception)
            {
                Console.WriteLine(
                    "ERROR: {0}:",
                    exception.GetType().Name);
                foreach(Exception item in
                    exception.InnerExceptions)
                {
                    Console.WriteLine("  {0} - {1}",
                        item.GetType().Name, item.Message);
                }
            }
        }

        // ...

        private static void Encrypt(string fileName)
        {
            // ...

            throw new UnauthorizedAccessException();
        }

    }

}





