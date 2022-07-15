namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_23
{
    public class Program
    {
        public static void Main(params string[] args)
        {
            int input = int.Parse(args[0]);

            #region INCLUDE
            if (input < 9)
                #region HIGHLIGHT
                System.Console.WriteLine("Exiting");
            #endregion HIGHLIGHT
            #endregion INCLUDE
        }
    }
}
