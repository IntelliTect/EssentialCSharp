namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_42
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            // ...
            DirectoryInfo directory = new DirectoryInfo(".\\Source");
            directory.MoveTo(".\\Root");
            DirectoryInfoExtension.CopyTo(
                directory, ".\\Target",
                SearchOption.AllDirectories, "*");
            // ...
        }

        public static class DirectoryInfoExtension
        {
            public static void CopyTo(
                DirectoryInfo sourceDirectory, string target,
                SearchOption option, string searchPattern)
            {
                if(target[target.Length - 1] !=
                    Path.DirectorySeparatorChar)
                {
                    target += Path.DirectorySeparatorChar;
                }
                if(!Directory.Exists(target))
                {
                    Directory.CreateDirectory(target);
                }

                for(int i = 0; i < searchPattern.Length; i++)
                {
                    foreach(string file in
                        Directory.GetFiles(
                            sourceDirectory.FullName, searchPattern))
                    {
                        File.Copy(file,
                            target + Path.GetFileName(file), true);
                    }
                }

                //Copy subdirectories (recursively)
                if(option == SearchOption.AllDirectories)
                {
                    foreach(string element in
                        Directory.GetDirectories(
                            sourceDirectory.FullName))
                    {
                        Copy(element,
                            target + Path.GetFileName(element),
                            searchPattern);
                    }
                }
            }
            private static void Copy(string element, string fileName, string searchPattern)
            {
                Console.WriteLine("Copying " + fileName);
            }
        }
    }
}
