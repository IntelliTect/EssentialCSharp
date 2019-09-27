namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_18
{
    using System;
    using System.Diagnostics;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            string fileName = @"enumtest.txt";
            FileInfo file = new FileInfo(fileName);
            file.Open(FileMode.Create).Dispose();

            FileAttributes startingAttributes =
                file.Attributes;

            file.Attributes = FileAttributes.Hidden |
                FileAttributes.ReadOnly;

            Console.WriteLine("\"{0}\" outputs as \"{1}\"",
                file.Attributes.ToString().Replace(",", " |"),
                file.Attributes);

            FileAttributes attributes =
                (FileAttributes)Enum.Parse(typeof(FileAttributes),
                file.Attributes.ToString());

            Console.WriteLine(attributes);

            File.SetAttributes(fileName,
                startingAttributes);
            file.Delete();
        }
    }
}
