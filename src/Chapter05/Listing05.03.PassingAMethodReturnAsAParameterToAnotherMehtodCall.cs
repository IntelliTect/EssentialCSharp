namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_03
{
    #region INCLUDE
    public class Program
    {
        public static void Main()
        {
            System.Console.Write("Enter your first name: ");
            System.Console.WriteLine("Hello {0}!",
            #region HIGHLIGHT
                System.Console.ReadLine());
            #endregion HIGHLIGHT
        }
    }
    #endregion INCLUDE
}
