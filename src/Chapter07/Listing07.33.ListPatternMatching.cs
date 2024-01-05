using System.Diagnostics;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_33;

public class Program
{
    #region INCLUDE
    public static void Main(string[] args)
    {
        // Ϊ�˼򻯣�����ѡ��ٶ�ȫСд

        // ��һ����������'/', '-'��'--'��ǰ׺��ע��ѡ��

        switch (args)
        {
            case ["--help" or ['/' or '-', 'h' or '?']]:
                // ��: --help, /h, -h, /?, -? 
                DisplayHelp();
                break;
            case [ ['/' or '-', char option], ..]:
                // ѡ����'/', '-'��ͷ����0�������ʵ��
                if(!EvaluateOption($"{option}", args[1..]))
                {
                    DisplayHelp();
                }
                break;
            case [ ['-', '-', ..] option, ..]:
                // ѡ����"--"��ͷ����0�������ʵ��
                if(!EvaluateOption(option[2..], args[1..]))
                {
                    DisplayHelp();
                }
                break;

            // ������case���ṩĬ���ж��Ƕ���ģ���Ϊ����default�ظ��ˣ�
            // ֻ�ǳ�����ʾĿ�Ķ��ṩ��
            case []:
                // δ�ṩ�����в���

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
        Console.WriteLine($"���� '{sourceFile}' '{targetFile}'...");
        return true;
    }
    #endregion INCLUDE
    
    private static bool CatalogFile(string fileName)
    {
        Console.WriteLine($"��¼ '{fileName}'...");
        return true;
    }

    private static void DisplayHelp()
    {
        Console.WriteLine("�������...");
    }
}
