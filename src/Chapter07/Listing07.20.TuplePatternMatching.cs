using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_20
{
    using System.IO;

    #region INCLUDE
    public class Program
    {
        const int Action = 0;
        const int FileName = 1;
        public const string DataFile = "data.dat";

        static public void Main(params string[] args)
        {
            // ...
            #region HIGHLIGHT
            if ((args.Length, args[Action]) is (1, "show"))
            #endregion HIGHLIGHT
            {
                Console.WriteLine(File.ReadAllText(DataFile));
            }
            #region HIGHLIGHT
            else if ((args.Length, args[Action].ToLower(), args[FileName]) 
                is (2, "encrypt", string fileName))
            #endregion HIGHLIGHT
            {
                string data = File.ReadAllText(DataFile);
                File.WriteAllText(fileName, Encrypt(data).ToString());
            }
            // ...
        }
        #region EXCLUDE
        public static string Encrypt(string data)
        {
            // See Chapter 19 for actual encryption implementation
            return $"ENCRYPTED <{data}> ENCRYPTED";
        }
        #endregion EXCLUDE
    }
    #endregion INCLUDE
}
