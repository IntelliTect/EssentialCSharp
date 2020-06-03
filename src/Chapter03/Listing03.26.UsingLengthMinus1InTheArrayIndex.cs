// Justification: Demonstrating how to use the length to index the last item in the array.
#pragma warning disable IDE0056 // Use index operator
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_26
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
