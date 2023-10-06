using System.Diagnostics;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_33;

public class Program
{
    #region INCLUDE
    public static void Main(string[] args)
    {
        // For simplicity, options are assumed
        // to all be lower case.

        // The first argument is the option and is
        // identified by a '/', '-', or '--' prefix.

        switch (args)
        {
            case ["--help" or ['/' or '-', 'h' or '?']]:
                // e.g. --help, /h, -h, /?, -? 
                DisplayHelp();
                break;
            case [ ['/' or '-', char option], ..]:
                // Option begins with '/', '-' and has 0 or more arguments.
                if(!EvaluateOption($"{option}", args[1..]))
                {
                    DisplayHelp();
                }
                break;
            case [ ['-', '-', ..] option, ..]:
                // Option begins with "--" and has 0 or more arguments.
                if(!EvaluateOption(option[2..], args[1..]))
                {
                    DisplayHelp();
                }
                break;

            // The following cases are redundant with default
            // but provided for demonstration purposes.
            case []:
                // No command line arguments

            default:
                DisplayHelp();
                break;
        }
    }

    private static bool EvaluateOption(string option, string[] args) =>
        (option, args) switch
        {
            ("cat" or "c", [string fileName]) =>
                CatalogFile(fileName),
            ("copy", [string sourceFile, string targetFile]) =>
                CopyFile(sourceFile, targetFile),
            _ => false
        };

    private static bool CopyFile(object sourceFile, string targetFile)
    {
        Console.WriteLine($"Copy '{sourceFile}' '{targetFile}'...");
        return true;
    }
    #endregion INCLUDE
    
    private static bool CatalogFile(string fileName)
    {
        Console.WriteLine($"Catalog '{fileName}'...");
        return true;
    }

    private static void DisplayHelp()
    {
        Console.WriteLine("Command Help...");
    }
}
