namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_11
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // ...
            string fullName;
            string driveLetter = "C:";
            string folderPath = "Data";
            string fileName = "index.html";

            fullName = Combine(driveLetter, folderPath, fileName);

            Console.WriteLine(fullName);
            // ...
        }

        static string Combine(
            string driveLetter, string folderPath, string fileName)
        {
            string path;
            path = string.Format("{1}{0}{2}{0}{3}",
                System.IO.Path.DirectorySeparatorChar,
                driveLetter, folderPath, fileName);
            return path;
        }
    }
}