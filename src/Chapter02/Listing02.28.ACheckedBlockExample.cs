namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_28;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        #region HIGHLIGHT
        checked
        {
            #endregion HIGHLIGHT
            // int.MaxValue equals 2147483647
            int n = int.MaxValue;
            n = n + 1;
            Console.WriteLine(n);
            #region HIGHLIGHT
        }
        #endregion HIGHLIGHT
        #endregion INCLUDE
    }
}
