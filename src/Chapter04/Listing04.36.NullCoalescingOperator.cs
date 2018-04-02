namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_36
{
    public class Program
    {
        public static void Main()
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
