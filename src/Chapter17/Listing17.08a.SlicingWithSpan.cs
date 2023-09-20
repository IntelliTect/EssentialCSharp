namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing017_08a;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string[] languages = new [] {
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Swift",
            "Python", "Lisp", "JavaScript"};

        Span<string> languageSpan = languages.AsSpan(1);

        System.Diagnostics.Trace.Assert(
            ReferenceEquals( languages[1], languageSpan[0]));

        Span<int> numbers = languages.Select(item => item.Length).ToArray().AsSpan();

        /*
        Console.WriteLine($@"^3..^0: {
            string.Join(", ", span[^3..^0]) // Python, Lisp, JavaScript
        }");
        Console.WriteLine($@" 3..^3: {
            string.Join(", ", span[3..^3]) // C++, TypeScript, Swift
        }");
        Console.WriteLine($@"  ..^6: {
            string.Join(", ", span[..^6])  // C#, COBOL, Java
        }");
        Console.WriteLine($@"   6..: {
            string.Join(", ", span[6..])  // Python, Lisp, JavaScript
        }");
        Console.WriteLine($@"    ..: {
            // C#, COBOL, Java, C++, TypeScript, Swift, Python, Lisp, JavaScript
            string.Join(", ", span[..])  // Python, Lisp, JavaScript
        }");
        Console.WriteLine($@"    ..: {
            // C#, COBOL, Java, C++, TypeScript, Swift, Python, Lisp, JavaScript
            string.Join(", ", span[0..^0])  // Python, Lisp, JavaScript
        }");
        
        */
        #endregion INCLUDE
    }
}
