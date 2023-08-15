namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_28;

public class Program
{
    #region INCLUDE
    public static void Main(params string[] args)
    {
        const int action = 0;
        const int fileName = 1;
        const string dataFile = "data.dat";

        // ...
        #region HIGHLIGHT
        switch ((args.Length, args[action].ToLower()))
        {
            case (1, "cat"):
                Console.WriteLine(File.ReadAllText(dataFile));
                break;
            case (2, "encrypt"):
        #endregion HIGHLIGHT
                {
                    string data = File.ReadAllText(dataFile);
                    File.WriteAllText(
                        args[fileName], Encrypt(data).ToString());
                }
                break;
            default:
                Console.WriteLine("Arguments are invalid.");
                break;
        }
    }
    #endregion INCLUDE

    public static string Encrypt(string data)
    {
        // See Chapter 19 for actual encryption implementation
        return $"ENCRYPTED <{data}> ENCRYPTED";
    }
}
