namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_03;

public class Program
{
    #region INCLUDE
    public static void Main()
    {
        Console.Write("请输入你的名字: ");
        #region HIGHLIGHT
        Console.WriteLine($"你好，{ Console.ReadLine() }！");
        #endregion HIGHLIGHT
    }
    #endregion INCLUDE
}
