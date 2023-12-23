namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_23;

public class Program
{
    public static void Main()
    {
        string[] languages = new[] {
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Visual Basic",
            "Python", "Lisp", "JavaScript" };
        // ...
        #region INCLUDE
        Console.WriteLine(
            $"数组中有{languages.Length}种语言。");
        #endregion INCLUDE
    }
}
