namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_09;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // 显示：-∞（负无穷大）
        Console.WriteLine(-1f / 0);

        // 显示：∞（正无穷大）
        Console.WriteLine(3.402823E+38f * 2f);
        #endregion INCLUDE
    }
}
