using System.Diagnostics;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_32;

public class Program
{
    #region INCLUDE
    public static void Main(params string[] args)
    {
        // For simplicitly, commands are assumed
        // to all be lower case.

        // The first argument is the command and is
        // identified by a '/', '-', or '--' prefix.

        switch (args)
        {
            case ["--help" or ['/' or '-', 'h' or '?']]:
                // e.g. /?, -?, /h, -h, --help
                DisplayHelp();
                break;
            case [ ['/' or '-', char command], ..]:
                // Command begins with '/', '-' and has 0 or more arguments.
                if(!ExecuteCommand($"{command}", args[1..]))
                {
                    DisplayHelp();
                }
                break;
            case [ ['-', '-', ..] command, ..]:
                // Command begins with "--" and has 0 or more arguments.
                if(!ExecuteCommand(command[2..], args[1..]))
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

    private static bool ExecuteCommand(string command, string[] args) =>
        (command, args) switch
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