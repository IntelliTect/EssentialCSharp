namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_24
{
    public class Program
    {
        public static void Main()
        {
            string[] languages = new string[9];
            // ...
            #region INCLUDE
            System.Console.WriteLine(
                $"There are {languages.Length} languages in the array.");
            #endregion INCLUDE
        }
    }
}
