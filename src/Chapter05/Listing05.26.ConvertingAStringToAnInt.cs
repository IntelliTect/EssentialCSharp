namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_26;

public class ExceptionHandling
{
    #region INCLUDE
    public static void Main()
    {
        string? firstName;
        string ageText;
        int age;

        Console.WriteLine("嘿，你！");

        Console.Write("请输入你的名字: ");
        firstName = Console.ReadLine();

        #region HIGHLIGHT
        Console.Write("请输入你的年龄: ");
        // 假设不为空
        ageText = Console.ReadLine()!;
        age = int.Parse(ageText);

        Console.WriteLine(
            $"你好，{ firstName }！你有{ age * 12 }个月大了。");
        #endregion HIGHLIGHT
    }
    #endregion INCLUDE
}
