namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_25;

public class Program
{
    #region INCLUDE
    public static void Main()
    {
        int? age;
        //...

        // 清除age的值
        age = null;

        #region EXCLUDE
        Console.WriteLine($"年龄是: {age}");
        #endregion EXCLUDE
    }
    #endregion INCLUDE
}
