namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_20;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string[] languages = new [] {
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Visual Basic",
            "Python", "Lisp", "JavaScript" };
        // 将"C++"存储到language变量中
        string language = languages[3];
        // 将"Java"赋给原本是"C++"的位置
        languages[3] = languages[2];
        // 将language的值赋给"Java"的位置
        languages[2] = language;
        #endregion INCLUDE
    }
}
