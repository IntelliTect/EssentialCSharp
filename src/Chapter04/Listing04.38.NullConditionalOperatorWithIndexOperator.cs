namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_38
{
    class Program
    {
        public static void Main(string[] args)
        {
            // CAUTION: args?.Length not verified
            string directoryPath = args?[0];
            string searchPattern = args?[1];
            // ...
        }

    }
}
