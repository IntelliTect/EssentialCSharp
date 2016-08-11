namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_48
{
    public class Program
    {
        public static void ChapterMain()
        {
            string[] languages = new string[9];
            // ...
            // RUNTIME ERROR: index out of bounds – should
            // be 8 for the last element
            languages[4] = languages[9];
        }
    }
}
