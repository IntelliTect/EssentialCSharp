namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_19;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string[] languages = new []{
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Visual Basic",
            "Python", "Lisp", "JavaScript"};
            // Retrieve fifth item in languages array (TypeScript)
            string language = languages[4];
        // Write "TypeScript"
        Console.WriteLine(language);
            // Retrieve second item from the end (Python)
            language = languages[^3];
        // Write "Python"
        Console.WriteLine(language);
        #endregion INCLUDE
    }
}
