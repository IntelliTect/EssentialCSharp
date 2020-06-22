using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_20
{
    using System.IO;

    public class Program
    {
        const int Action = 0;
        const int FileName = 1;

        public const string DataFile = "data.dat";

        static public void Main(params string[] args)
        {
            // ...

            if ((args.Length, args[Action]) is
                 (1, "show"))
            {
                Console.WriteLine(File.ReadAllText(DataFile));
            }
            else if ((args.Length, args[Action].ToLower(), args[FileName]) is 
                (2, "encrypt", string fileName))
            {
                string data = File.ReadAllText(DataFile);
                File.WriteAllText(fileName, Encrypt(data).ToString());
            }
            // ...
        }

        public static string Encrypt(string data)
        {
            // See Chapter 19 for actual encryption implementation
            return $"ENCRYPTED <{data}> ENCRYPTED";
        }
    }
}
