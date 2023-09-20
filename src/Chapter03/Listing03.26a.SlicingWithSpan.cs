namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_26a;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string[] languages = new [] {
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Swift",
            "Python", "Lisp", "JavaScript"};

        Span<string> span = languages.AsSpan(1);

        System.Diagnostics.Trace.Assert(
            ReferenceEquals( languages[1], span[0]));
        
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
