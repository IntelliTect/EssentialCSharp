namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_25;

public class Program
{
    #region INCLUDE
    public static void Main()
    {
        int? age;
        //...

        // ���age��ֵ
        age = null;

        #region EXCLUDE
        Console.WriteLine($"������: {age}");
        #endregion EXCLUDE
    }
    #endregion INCLUDE
}
