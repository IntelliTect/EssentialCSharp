namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_24;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string[] languages = new string[9];
        // ...
        // 运行时错误：索引越界 - 最后一个元素的索引应为8
        languages[4] = languages[9];
        #endregion INCLUDE
    }
}
