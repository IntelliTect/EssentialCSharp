// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_02;

public class ArrayHighlights
{
    // 1.
    public static void Declaration()
    {
        string[] languages; // one-dimensional
        int[,] cells;       // two-dimensional
    }

    // 2.
    public static void Assignment()
    {
        string[] languages = {
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Pascal",
            "Python", "Lisp", "JavaScript"};
        languages = new string[]{
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Pascal",
            "Python", "Lisp", "JavaScript" };
        // Multidimensional array assignment
        // and initialization
        int[,] cells = new [,] {
            { 1, 0, 2},
            { 1, 2, 0},
            { 1, 2, 1}
        };
        languages = new string[9];
    }

    // 3.
    public static void ForwardAndReverseAccessingAnArray()
    {
        string[] languages = new []{
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Visual Basic",
            "Python", "Lisp", "JavaScript"};
        // Retrieve fifth item in languages array (TypeScript)
        string language = languages[4];
        // Write “TypeScript”
        Console.WriteLine(language);
        // Retrieve third item from the end (Python)
        language = languages[^3];
        // Write “Python”
        Console.WriteLine(language);
    }

    // 4.
    public static void Ranges()
    {
        string[] languages = new []{
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Visual Basic",
            "Python", "Lisp", "JavaScript"};

        Console.WriteLine($@"^3..^0: {
            // Python, Lisp, JavaScript
            string.Join(", ", languages[^3..^0])
        }");
        Console.WriteLine($@"^3..: {
            // Python, Lisp, JavaScript
            string.Join(", ", languages[^3..])
        }");
        Console.WriteLine($@" 3..^3: {
            // C++, TypeScript, Visual Basic
            string.Join(", ", languages[3..^3])
        }");
        Console.WriteLine($@"  ..^6: {
            // C#, COBOL, Java
            string.Join(", ", languages[..^6])
        }");
    }
}
