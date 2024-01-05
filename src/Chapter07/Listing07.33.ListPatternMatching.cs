using System.Diagnostics;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_33;

public class Program
{
    #region INCLUDE
    public static void Main(string[] args)
    {
        // 为了简化，所有选项假定全小写

        // 第一个参数是用'/', '-'或'--'等前缀标注的选项

        switch (args)
        {
            case ["--help" or ['/' or '-', 'h' or '?']]:
                // 例: --help, /h, -h, /?, -? 
                DisplayHelp();
                break;
            case [ ['/' or '-', char option], ..]:
                // 选项以'/', '-'开头，有0个或更多实参
                if(!EvaluateOption($"{option}", args[1..]))
                {
                    DisplayHelp();
                }
                break;
            case [ ['-', '-', ..] option, ..]:
                // 选项以"--"开头，有0个或更多实参
                if(!EvaluateOption(option[2..], args[1..]))
                {
                    DisplayHelp();
                }
                break;

            // 用以下case来提供默认行动是多余的，因为它和default重复了，
            // 只是出于演示目的而提供。
            case []:
                // 未提供命令行参数

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
        Console.WriteLine($"复制 '{sourceFile}' '{targetFile}'...");
        return true;
    }
    #endregion INCLUDE
    
    private static bool CatalogFile(string fileName)
    {
        Console.WriteLine($"编录 '{fileName}'...");
        return true;
    }

    private static void DisplayHelp()
    {
        Console.WriteLine("命令帮助...");
    }
}
