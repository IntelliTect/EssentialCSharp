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
            // ��ȡlanguages����ĵ�����(TypeScript)
            string language = languages[4];
        // ���"TypeScript"
        Console.WriteLine(language);
            // ��ȡ����������(Python)
            language = languages[^3];
        // ���"Python"
        Console.WriteLine(language);
        #endregion INCLUDE
    }
}
