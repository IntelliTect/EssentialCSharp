namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_23;

public class Uppercase
{
    public static void Main()
    {
        #region INCLUDE
        Console.Write("输入文本: ");
        string text = Console.ReadLine();

        #region HIGHLIGHT
        // UNEXPECTED: text并没有转换为全大写
        text.ToUpper();
        #endregion HIGHLIGHT

        Console.WriteLine(text);
        #endregion INCLUDE
    }
}
