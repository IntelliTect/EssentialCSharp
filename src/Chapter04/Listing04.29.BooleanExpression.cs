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
            // ����С��9
            Console.WriteLine("�����������" + $"����{input}");
        }
        // ...
        #endregion INCLUDE
    }
}
