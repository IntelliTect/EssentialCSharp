namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_44;

public class FibonacciCalculator
{
    public static void Main()
    {
        #region INCLUDE
        decimal current;
        decimal previous;
        decimal temp;
        decimal input;

        Console.Write("输入一个正整数:");

        // decimal.Parse将ReadLine的返回结果转换为一个十进制数，
        // 如果ReadLine返回null，就用"42"作为默认值。
        input = decimal.Parse(Console.ReadLine() ?? "42");

        // 将current和previous初始化为1，这是
        // 斐波那契数列前两个固定的数。
        current = previous = 1;

        // 判断数列中当前的斐波那契数是否
        // 小于用户输入的数        
        while (current <= input)
        {
            temp = current;
            current = previous + current;
            previous = temp; // 即使上一个语句造成current大于input，
                             // 也会执行这个语句。
        }

        Console.WriteLine(
                  $"下一个斐波那契数是{ current }");
        #endregion INCLUDE
    }
}
