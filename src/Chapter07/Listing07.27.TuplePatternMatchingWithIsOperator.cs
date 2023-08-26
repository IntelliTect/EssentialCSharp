namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_27;

using System.IO;
using System.Runtime.CompilerServices;


public class Program
{

    #region INCLUDE
    public static void Main(params string[] args)
    {
        const int command = 0;
        const int fileName = 1;
        const string dataFile = "data.dat";

        // ...
        #region HIGHLIGHT
        if ((args.Length, args[command].ToLower()) is (1, "cat"))
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
            File.WriteAllText(
                args[fileName], Encrypt(data).ToString());
        }
    }
    #endregion INCLUDE

    public static string Encrypt(string data)
    {
        // See Chapter 19 for actual encryption implementation
        return $"ENCRYPTED <{data}> ENCRYPTED";
    }
}
