// Disabled because not attributes have not been covered
// and the attribute is not available in .NET 6.0.
#pragma warning disable SYSLIB1045 // Convert to 'GeneratedRegexAttribute'.

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_12;

#region INCLUDE
// The using directive imports all types from the 
// specified namespace into the entire file
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        #region EXCLUDE
        const string firstName = "FirstName";
        const string initial = "Initial";
        const string lastName = "LastName";

        // Explaining regular expressions is beyond the
        // scope of this book.
        // See https://www.regular-expressions.info/ for
        // more information.
        const string pattern = $"""
            (?<{firstName}>\w+)\s+((?<{initial}>\w)\.\s+)?(?<{lastName}>\w+)\s*
            """;

        Console.WriteLine(
            "Enter your full name (e.g. Inigo T. Montoya): ");
        string name = Console.ReadLine()!;

        #endregion EXCLUDE
        #region HIGHLIGHT
        // No need to qualify RegEx type with
        // System.Text.RegularExpressions because
        // of the using directive above
        Match match = Regex.Match(name, pattern);
        #endregion HIGHLIGHT
        #region EXCLUDE

        if (match.Success)
        {
            Console.WriteLine(
                $"{firstName}: {match.Groups[firstName]}");
            Console.WriteLine(
                $"{initial}: {match.Groups[initial]}");
            Console.WriteLine(
                $"{lastName}: {match.Groups[lastName]}");
        }
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
