namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_17
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            string fullName;

            // ...

            // Call Combine() with four parameters
            fullName = Combine(
                Directory.GetCurrentDirectory(),
                "bin", "config", "index.html");
            Console.WriteLine(fullName);

            // ...

            // Call Combine() with only three parameters
            fullName = Combine(
                Directory.GetParent(Directory.GetCurrentDirectory()).FullName,
                "Temp", "index.html");
            Console.WriteLine(fullName);

            // ...

            // Call Combine() with an array
            fullName = Combine(
                new string[] {
                    $"C:{Path.DirectorySeparatorChar}", "Data",
                    "HomeDir", "index.html" });
            Console.WriteLine(fullName);
            // ...
        }

        static string Combine(params string[] paths)
        {
            string result = string.Empty;
            foreach(string path in paths)
            {
                result = System.IO.Path.Combine(result, path);
            }
            return result;
        }
    }
}