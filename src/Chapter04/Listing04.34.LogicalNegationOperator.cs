namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_34
{
    public class Program
    {
        public static void Main()
        {
            #region INCLUDE
            bool valid = false;
            #region HIGHLIGHT
            bool result = !valid;
            #endregion HIGHLIGHT
            // Displays "result = True"
            System.Console.WriteLine($"result = { result }");
            #endregion INCLUDE
        }
    }
}
