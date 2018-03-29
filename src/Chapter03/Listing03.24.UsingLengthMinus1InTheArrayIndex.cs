namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_24
{
    public class Program
    {
        public static void Main()
        {
            string[] languages = new string[9];
            // ...
            languages[4] = languages[languages.Length - 1];
        }
    }
}
