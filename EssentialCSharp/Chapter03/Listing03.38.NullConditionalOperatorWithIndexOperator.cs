namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_36B
{
    class Program
    {
        public static void ChapterMain(string[] args)
        {
            // CAUTION: args?.Length not verified.
            string directoryPath = args?[0];
            string searchPattern = args?[1];
            // ...
        }

    }
}
