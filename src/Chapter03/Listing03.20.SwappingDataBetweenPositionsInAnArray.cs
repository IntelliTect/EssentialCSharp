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
        // ��"C++"�洢��language������
        string language = languages[3];
        // ��"Java"����ԭ����"C++"��λ��
        languages[3] = languages[2];
        // ��language��ֵ����"Java"��λ��
        languages[2] = language;
        #endregion INCLUDE
    }
}
