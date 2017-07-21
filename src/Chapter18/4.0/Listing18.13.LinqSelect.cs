namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_13
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;
    using System.IO;

    
    class Cryptographer
    {
        public List<string> SynchronousEncrypt(List<string> data)
        {
          return data.Select<string,string>(
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

        public static void Main()
        {
            List<string> files = Directory.GetFiles(Directory.GetCurrentDirectory()).ToList();
            int numberOfFiles = files.Count;
            DateTime timeBefore = DateTime.Now;
            Cryptographer cryptographer = new Cryptographer();
            List<string> returnedfiles = cryptographer.SynchronousEncrypt(files);
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
