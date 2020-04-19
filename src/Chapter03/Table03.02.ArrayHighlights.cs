// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_02
{
    public class ArrayHighlights
    {
        // 1.
        static public void Declaration()
        {
            string[] languages; // one-dimensional
            int[,] cells;       // two-dimensional
        }

        // 2.
        static public void Assignment()
        {
            string[] languages = { "C#", "COBOL", "Java",
                "C++", "TypeScript", "Pascal",
                "Python", "Lisp", "JavaScript"};
            languages = new string[9];
            languages = new string[]{"C#", "COBOL", "Java",
                "C++", "TypeScript", "Pascal",
                "Python", "Lisp", "JavaScript" };
            // Multidimensional array assignment
            // and initialization
            int[,] cells = new int[3, 3] {
                { 1, 0, 2},
                { 1, 2, 0},
                { 1, 2, 1}
            };
        }

        // 3.
        static public void ForwardAndReverseAccessingAnArray()
        {
            string[] languages = new string[]{
                "C#", "COBOL", "Java",
                "C++", "TypeScript", "Visual Basic",
                "Python", "Lisp", "JavaScript"};
            // Retrieve fifth item in languages array (TypeScript)
            string language = languages[4];
            // Write “TypeScript”
            System.Console.WriteLine(language);
            // Retrieve second item from the end (Python)
            language = languages[^3];
            // Write “Python”
            System.Console.WriteLine(language);
        }

        // 4.
        static public void Ranges()
        {
            string[] languages = new string[]{
                "C#", "COBOL", "Java",
                "C++", "TypeScript", "Visual Basic",
                "Python", "Lisp", "JavaScript"};

            System.Console.WriteLine($@"^3..^0: {
                // Python, Lisp, JavaScript
                string.Join(", ", languages[^3..^0])
            }");
            System.Console.WriteLine($@"^3..: {
                // Python, Lisp, JavaScript
                string.Join(", ", languages[^3..])
            }");
            System.Console.WriteLine($@" 3..^3: {
                // C++, TypeScript, Visual Basic
                string.Join(", ", languages[3..^3])
            }");
            System.Console.WriteLine($@"  ..^6: {
                // C#, COBOL, Java
                string.Join(", ", languages[..^6])
            }");
        }
    }
}
