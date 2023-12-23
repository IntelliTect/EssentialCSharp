namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_01;

public class Program
{
    #region INCLUDE
    public static void Main(string[] args)
    {
        int? number = null;
        #region EXCLUDE
        if (args.Length>0)
        {
            number = args[0].Length;
        }
        #endregion EXCLUDE
        if (number is null)
        {
            Console.WriteLine("需要为'number'提供一个值，不允许为null。");
        }
        else
        {
            Console.WriteLine($"你在命令行提供的第一个参数包括{number}个字符/字。");
            Console.WriteLine($"'number'的两倍是{number * 2}。");
        }
    }
    #endregion INCLUDE
}

