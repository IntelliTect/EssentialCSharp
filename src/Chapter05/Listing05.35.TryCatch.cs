namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_35;

public class LeveragingTryParse
{
    public static void Main()
    {
        string? firstName;
        string ageText;

        Console.Write("请输入你的名字: ");
        firstName = Console.ReadLine();

        Console.Write("请输入你的年龄: "); 
        // Assume not null for clarity
        ageText = Console.ReadLine()!;
        #region INCLUDE
        if (int.TryParse(ageText, out int age))
        {
            Console.WriteLine(
                $"你好，{ firstName }！" +
                $"你有{age * 12}个月大了。");
        }
        else
        {
            Console.WriteLine(
                $"你输入的年龄'{ageText}'不是一个有效的整数。");
        }
        #endregion INCLUDE
    }
}
