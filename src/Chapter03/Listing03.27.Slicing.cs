namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_27
{
    public class Program
    {
        public static void Main()
        {
            string[] languages = new string[] {
                "C#", "COBOL", "Java",
                "C++", "TypeScript", "Swift",
                "Python", "Lisp", "JavaScript"};

            System.Console.WriteLine($@"  0..3: {
                string.Join(", ", languages[0..3])  // C#, COBOL, Java
            }"); 
            System.Console.WriteLine($@"^3..^0: {
                string.Join(", ", languages[^3..^0]) // Python, Lisp, JavaScript
            }"); 
            System.Console.WriteLine($@" 3..^3: {
                string.Join(", ", languages[3..^3]) // C++, TypeScript, Swift
            }");
            System.Console.WriteLine($@"  ..^6: {
                string.Join(", ", languages[..^6])  // C#, COBOL, Java
            }");
            System.Console.WriteLine($@"   6..: {
                string.Join(", ", languages[6..])  // Python, Lisp, JavaScript
            }");
            System.Console.WriteLine($@"    ..: {
                // C#, COBOL, Java, C++, TypeScript, Swift, Python, Lisp, JavaScript
                string.Join(", ", languages[..])  // Python, Lisp, JavaScript
            }");
            System.Console.WriteLine($@"    ..: {
                // C#, COBOL, Java, C++, TypeScript, Swift, Python, Lisp, JavaScript
                string.Join(", ", languages[0..^0])  // Python, Lisp, JavaScript
            }");
        }
    }
}
