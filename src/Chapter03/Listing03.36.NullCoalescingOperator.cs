namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_36
{
    public class Program
    {
        public static void ChapterMain()
        {
            string fileName = GetFileName();
            // ...
            string fullName = fileName ?? "default.txt";
            // ...
        }

        private static string GetFileName()
        {
            throw new System.NotImplementedException();
        }
    }
}
