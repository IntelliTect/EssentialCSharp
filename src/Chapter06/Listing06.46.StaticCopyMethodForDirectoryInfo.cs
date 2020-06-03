namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_46
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            DirectoryInfo directory = new DirectoryInfo(".\\Source");
            directory.CopyTo(".\\Target",
                SearchOption.TopDirectoryOnly, "*");//Extension method. Is Defined below but appears to be a member of the DirectoryInfo object, directory, defined aboves       
        }
    }
    public static class DirectoryInfoExtension
    {
        public static void CopyTo(
            this DirectoryInfo sourceDirectory, string target,
            SearchOption option, string searchPattern)
        {
            if(target[target.Length - 1] != Path.DirectorySeparatorChar)
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

            //Copy SubDirectories (recursively)
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
