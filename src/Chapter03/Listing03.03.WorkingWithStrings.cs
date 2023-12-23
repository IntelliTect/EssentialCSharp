namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_03;

public class Uppercase
{
    public static void Main()
    {
        #region INCLUDE
        Console.Write("输入文本: ");
        var text = Console.ReadLine();

        // 返回全大写的一个新字符串
        var uppercase = text.ToUpper();
        Console.WriteLine(uppercase);
        #endregion INCLUDE
    }
}
