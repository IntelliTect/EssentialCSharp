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
            // 获取languages数组的第五项(TypeScript)
            string language = languages[4];
        // 输出"TypeScript"
        Console.WriteLine(language);
            // 获取倒数第三项(Python)
            language = languages[^3];
        // 输出"Python"
        Console.WriteLine(language);
        #endregion INCLUDE
    }
}
