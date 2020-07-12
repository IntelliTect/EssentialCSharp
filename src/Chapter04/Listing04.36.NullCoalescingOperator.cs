#pragma warning disable CS0168 // Variable is declared but never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value

using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_36
{
    public class Program
    {
        public static void Main()
        {
            string? fullName = GetDefaultDirectory();
            // ...

            // Null-coalescing operator
            string fileName = GetFileName() ?? "config.json";
            string directory = GetConfigurationDirectory() ??
                GetApplicationDirectory() ??
                System.Environment.CurrentDirectory;

            // Null-coalescing assignment operator
            fullName ??= $"{ directory }/{ fileName }";

            // ...


        }

        private static string? GetDefaultDirectory()
        {
            throw new NotImplementedException();
        }

        private static string? GetApplicationDirectory()
        {
            throw new NotImplementedException();
        }

        private static string? GetConfigurationDirectory()
        {
            throw new NotImplementedException();
        }

        private static string? GetFileName()
        {
            throw new System.NotImplementedException();
        }
    }
}
