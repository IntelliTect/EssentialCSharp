// Disabled because not attributes have not been covered
// and the attribute is not available in .NET 6.0.
#pragma warning disable SYSLIB1045 // Convert to 'GeneratedRegexAttribute'.

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_08;

#region INCLUDE
// using指令将所有类型从指定命名空间
// 导入当前代码文件。
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        const string firstName = "FirstName";
        const string initial = "Initial";
        const string lastName = "LastName";

        // 对正则表达式的详细解释超出了本书范围
        // 访问https://www.regular-expressions.info了解详情
        const string pattern = $"""
            (?<{firstName}>\w+)\s+((?<{
            initial}>\w)\.\s+)?(?<{
            lastName}>\w+)\s*
            """;

        Console.WriteLine(
            "输入你的全名 (例：Inigo T. Montoya): ");
        string name = Console.ReadLine()!;

        #region HIGHLIGHT
        // 因为之前的using指令，所以
        // 不需要用System.Text.RegularExpressions
        // 前缀来限定RegEx类型。        
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
