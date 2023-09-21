namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_09;

using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string[] languages = new [] {
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Python",};

        // Create a Span<string> from the arrays first 3 elements.
        Span<string> languageSpan = languages.AsSpan(0,2);
        languages[0] = "R";
        Trace.Assert(languages[0] == languageSpan[0]);
        Trace.Assert("R" == languageSpan[0]);
        languageSpan[0] = "Lisp";
        Trace.Assert(languages[0] == languageSpan[0]);
        Trace.Assert("Lisp" == languages[0]);

        int[] numbers = languages.Select(item => item.Length).ToArray();
        // Create a Span<string> from the arrays first 3 elements.
        Span<int> numbersSpan = numbers.AsSpan(0,2);
        Trace.Assert(numbers[1] == numbersSpan[1]);
        numbersSpan[1] = 42;
        Trace.Assert(numbers[1] == numbersSpan[1]);
        Trace.Assert(42 == numbers[1]);
        
        string bigWord = "supercalifragilisticexpialidocious";
        // Create a Span<char> from a suffix portion of the word.
        #if NET8_0_OR_GREATER
        ReadOnlySpan<char> expialidocious = bigWord.AsSpan(20..);
        #else // NET8_0_OR_GREATER
        ReadOnlySpan<char> expialidocious = bigWord.AsSpan(20, 14);
        #endif // NET8_0_OR_GREATER
        Trace.Assert(expialidocious.ToString() == "expialidocious");
#endregion INCLUDE
    }
}
