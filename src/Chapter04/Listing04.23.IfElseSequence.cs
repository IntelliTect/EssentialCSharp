namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_23;

public class Program
{
    public static void Main(params string[] args)
    {
        int input = int.Parse(args[0]);
        #region INCLUDE
        if (input <= 0)
            Console.WriteLine("退出...");
        else if (input < 9)
            Console.WriteLine(
                "井字棋最大轮数" +
                $"大于{input}");
        else if (input > 9)
            Console.WriteLine(
                "井字棋最大轮数" +
                $"小于{input}");
        else
            Console.WriteLine(
                "正确，井字棋最多" +
                "只能走9轮。");
        #endregion INCLUDE
    }
}
