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
                Console.WriteLine("参数无效。");
                break;
        }
    }
    #endregion INCLUDE

    public static string Encrypt(string data)
    {
        // 参见第19章，了解加密具体是如何实现的
        return $"ENCRYPTED <{data}> ENCRYPTED";
    }
}
