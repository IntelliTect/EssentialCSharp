namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_30;

public class Program
{
    #region INCLUDE
    public static void Main(string[] args)
    {
        // ...
        // 命令行输出的以空格分隔的每个参数都是一个字符串(字符数组),
        // 所有字符串构成了args字符串数组。
        string arg = args[0];
        if(arg[0] == '-')
        {
            // 该参数是选项
        }
    }
    #endregion INCLUDE
}
