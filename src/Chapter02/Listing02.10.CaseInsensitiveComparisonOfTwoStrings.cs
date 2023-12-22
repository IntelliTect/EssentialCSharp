namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_10;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        bool ignoreCase = true;
        string option = "/help";
        // ...
        int comparison = string.Compare(option, "/Help", ignoreCase);
        bool isHelpRequested = (comparison == 0);
        // 显示: 是否请求帮助: True
        Console.WriteLine($"是否请求帮助: {isHelpRequested}");
        #endregion INCLUDE

    }
}

