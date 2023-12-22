namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_24;
#region INCLUDE
public class Uppercase
{
    public static void Main()
    {
        string text, uppercase;

        Console.Write("输入文本: ");
        text = Console.ReadLine();

        // 返回全大写的一个新字符串
        #region HIGHLIGHT
        uppercase = text.ToUpper();
        #endregion HIGHLIGHT

        Console.WriteLine(uppercase);
    }
}
#endregion INCLUDE