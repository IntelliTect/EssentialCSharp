namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_26;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string[] languages = [
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Swift",
            "Python", "Lisp", "JavaScript"];

        // 1. C#, COBOL, Java
        Console.WriteLine($@" 0..3: {string.Join(", ", languages[0..3])}");

        // 2. Python, Lisp, JavaScript
        Console.WriteLine($@"^3..^0: {string.Join(", ", languages[^3..^0])}");

        // 3. C++, TypeScript, Swift
        Console.WriteLine($@" 3..^3: {string.Join(", ", languages[3..^3])}");

        // 4. C#, COBOL, Java
        Console.WriteLine($@" ..^6: {string.Join(", ", languages[..^6])}");

        // 5. Python, Lisp, JavaScript
        Console.WriteLine($@" 6..: {string.Join(", ", languages[6..])}");

        // 6. C#, COBOL, Java, C++, TypeScript, Swift, Python, Lisp, JavaScript
        Console.WriteLine($@" ..: {string.Join(", ", languages[..])}");

        // 7. C#, COBOL, Java, C++, TypeScript, Swift, Python, Lisp, JavaScript
        Console.WriteLine($@" 0..^0: {string.Join(", ", languages[0..^0])}");
        #endregion INCLUDE
    }
}
