namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_26;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string[] languages = new [] {
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Swift",
            "Python", "Lisp", "JavaScript"};

        Console.WriteLine($@"  0..3: {
            string.Join(", ", languages[0..3])  // C#, COBOL, Java
        }");
        Console.WriteLine($@"^3..^0: {
            string.Join(", ", languages[^3..^0]) // Python, Lisp, JavaScript
        }");
        Console.WriteLine($@" 3..^3: {
            string.Join(", ", languages[3..^3]) // C++, TypeScript, Swift
        }");
        Console.WriteLine($@"  ..^6: {
            string.Join(", ", languages[..^6])  // C#, COBOL, Java
        }");
        Console.WriteLine($@"   6..: {
            string.Join(", ", languages[6..])  // Python, Lisp, JavaScript
        }");
        Console.WriteLine($@"    ..: {
            // C#, COBOL, Java, C++, TypeScript, Swift, Python, Lisp, JavaScript
            string.Join(", ", languages[..])  // Python, Lisp, JavaScript
        }");
        Console.WriteLine($@"    ..: {
            // C#, COBOL, Java, C++, TypeScript, Swift, Python, Lisp, JavaScript
            string.Join(", ", languages[0..^0])  // Python, Lisp, JavaScript
        }");
        #endregion INCLUDE
    }
}
