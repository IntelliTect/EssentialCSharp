namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_36;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // 现在，作为out参数使用的变量不需要事先声明
        // double number;  
        string input;
        Console.Write("输入一个数字: ");
        input = Console.ReadLine();
        if (double.TryParse(input, out double number))
        {
            Console.WriteLine(
            $"输入被成功解析成数字: {number}.");
        }
        else
        {
            // 注意：number的作用域也延伸到这里(虽然未赋值)
            Console.WriteLine(
                "输入的文本不是一个有效的数字。");
        }
        Console.WriteLine(
            $"'number'目前的值是: {number}");
        #endregion INCLUDE
    }
}
