namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_14
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string rootDirectory = "example";
            string searchPattern = "example";

            IEnumerable<string> fileList = Directory.GetFiles(
                rootDirectory, searchPattern);
            IEnumerable<FileInfo> files = fileList.Select(
                file => new FileInfo(file));
        }
    }
}