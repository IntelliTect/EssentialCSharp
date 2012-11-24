namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_16
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            // ...

            string fileName = @"enumtest.txt";

            System.IO.FileInfo file =
                new System.IO.FileInfo(fileName);

            file.Attributes = FileAttributes.Hidden |
                FileAttributes.ReadOnly;

            Console.WriteLine("{0} | {1} = {2}",
                FileAttributes.Hidden, FileAttributes.ReadOnly,
                (int)file.Attributes);

            if ((file.Attributes & FileAttributes.Hidden) !=
                FileAttributes.Hidden)
            {
                throw new Exception("File is not hidden.");
            }

            if ((file.Attributes & FileAttributes.ReadOnly) !=
                FileAttributes.ReadOnly)
            {
                throw new Exception("File is not read-only.");
            }

            // ...
        }
    }
}
