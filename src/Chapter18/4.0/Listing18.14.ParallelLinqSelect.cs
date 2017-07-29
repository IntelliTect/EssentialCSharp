namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_14
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    class Cryptographer
    {
        public List<string> ParallelEncrypt(List<string> data)
        {
            return data.AsParallel().Select(
                (item) => Encrypt(item)).ToList();
        }

        private static string Encrypt(string fileName)
        {
            int oneSecond = 1000;

            Console.WriteLine(string.Format("-----Pretending to encrypt '{0}'.", fileName));
            Thread.Sleep(oneSecond);
            Console.WriteLine(string.Format("|||||Finished 'encrypting' '{0}'.", fileName));

            return fileName;
        }

        private static List<string> GetRandomNumbers()
        {
            List<string> numbers = new List<string>();
            Random random = new Random();
            for (int index = 0; index < 1000000; index++)
            {
                numbers.Add(random.Next().ToString());
            }

            return numbers;
        }

        public static void Main()
        {
            List<string> files = Directory.GetFiles(Directory.GetCurrentDirectory()).ToList();
            int numberOfFiles = files.Count;
            DateTime timeBefore = DateTime.Now;
            Cryptographer cryptographer = new Cryptographer();
            List<string> returnedfiles = cryptographer.ParallelEncrypt(files);
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