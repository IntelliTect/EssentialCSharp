namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_20;

using System.IO;
using System.Runtime.CompilerServices;


public class Program
{
    public class PositionalPatternMatchingIsOperator
    {
        public static void Main(params string[] args)
        {
            #region INCLUDE
            const int command = 0;
            const int fileName = 1;
            const string dataFile = "data.dat";

            // ...
            #region HIGHLIGHT
            if ((args.Length, args[command]) is (1, "show"))
            #endregion HIGHLIGHT
            {
                Console.WriteLine(File.ReadAllText(dataFile));
            }
            #region HIGHLIGHT
            else if ((args.Length, args[command].ToLower())
                is (2, "encrypt"))
            #endregion HIGHLIGHT
            {
                string data = File.ReadAllText(dataFile);
                File.WriteAllText(args[fileName], Encrypt(data).ToString());
            }

            #region EXCLUDE
        }
    }


    public class PositionalPatternMatchingSwtichStatement
    {
        #endregion EXCLUDE

        public static void Main(params string[] args)
        {
            const int action = 0;
            const int fileName = 1;
            const string dataFile = "data.dat";
            
            // ...
            #region HIGHLIGHT
            switch ((args.Length, args[action]))
            {
                case (1, "show"):
                    Console.WriteLine(File.ReadAllText(dataFile));
                    break;
                case (2, "encrypt"):
                    #endregion HIGHLIGHT
                    {
                        string data = File.ReadAllText(dataFile);
                        File.WriteAllText(args[fileName], Encrypt(data).ToString());
                    }
                    break;
                default:
                    Console.WriteLine("Arguments are invalid.");
                    break;
            }
        }
        #endregion INCLUDE
    }

    public static string Encrypt(string data)
    {
        // See Chapter 19 for actual encryption implementation
        return $"ENCRYPTED <{data}> ENCRYPTED";
    }
}
