namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_24
{
    #region INCLUDE
    public class Program
    {
        public static void Main()
        {
            unchecked
            {
                // int.MaxValue equals 2147483647
                int n = int.MaxValue;
                n = n + 1;
                Console.WriteLine(n);
            }
        }
    }
    #endregion INCLUDE
}
