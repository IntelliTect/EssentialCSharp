namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_03
{
    #region INCLUDE
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter your first name: ");
            Console.WriteLine("Hello {0}!",
            #region HIGHLIGHT
                Console.ReadLine());
            #endregion HIGHLIGHT
        }
    }
    #endregion INCLUDE
}
