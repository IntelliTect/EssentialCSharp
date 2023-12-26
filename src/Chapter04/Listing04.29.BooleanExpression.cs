namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_29;

public class Program
{
    public static void Main()
    {
        int input = 5;

        #region INCLUDE
        #region HIGHLIGHT
        if (input < 9)
        #endregion HIGHLIGHT
        {
            // 输入小于9
            Console.WriteLine("井字棋最大步数" + $"大于{input}");
        }
        // ...
        #endregion INCLUDE
    }
}
