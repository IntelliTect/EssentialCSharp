// Disabled because not attributes have not been covered
// and the attribute is not available in .NET 6.0.
#pragma warning disable SYSLIB1045 // Convert to 'GeneratedRegexAttribute'.

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_08;

#region INCLUDE
// usingָ��������ʹ�ָ�������ռ�
// ���뵱ǰ�����ļ���
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        const string firstName = "FirstName";
        const string initial = "Initial";
        const string lastName = "LastName";

        // ��������ʽ����ϸ���ͳ����˱��鷶Χ
        // ����https://www.regular-expressions.info�˽�����
        const string pattern = $"""
            (?<{firstName}>\w+)\s+((?<{
            initial}>\w)\.\s+)?(?<{
            lastName}>\w+)\s*
            """;

        Console.WriteLine(
            "�������ȫ�� (����Inigo T. Montoya): ");
        string name = Console.ReadLine()!;

        #region HIGHLIGHT
        // ��Ϊ֮ǰ��usingָ�����
        // ����Ҫ��System.Text.RegularExpressions
        // ǰ׺���޶�RegEx���͡�        
        Match match = Regex.Match(name, pattern);
        #endregion HIGHLIGHT

        if (match.Success)
        {
            Console.WriteLine(
                $"{firstName}: {match.Groups[firstName]}");
            Console.WriteLine(
                $"{initial}: {match.Groups[initial]}");
            Console.WriteLine(
                $"{lastName}: {match.Groups[lastName]}");
        }
    }
}
#endregion INCLUDE
