namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_27;

public class ProgrammingLanguages
{
    public static void Main()
    {
        #region INCLUDE
        string[] languages = {
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Swift",
            "Python", "Lisp", "JavaScript"};

        #region HIGHLIGHT
        Array.Sort(languages);
        #endregion HIGHLIGHT

        string searchString = "COBOL";
        #region HIGHLIGHT
        int index = Array.BinarySearch(
            languages, searchString);
        #endregion HIGHLIGHT
        Console.WriteLine("δ�����˳���" + $"{searchString}��λ������{index}��");
        Console.WriteLine();
        Console.WriteLine($"{"��һ��Ԫ��",-26}\t{"���һ��Ԫ��",-26}");
        Console.WriteLine($"{"--------------",-26}\t{"--------------",-26}");
        Console.WriteLine($"{languages[0],-26}\t{languages[^1],-26}");
        #region HIGHLIGHT
        Array.Reverse(languages);
        #endregion HIGHLIGHT
        Console.WriteLine($"{languages[0],-26}\t{languages[^1],-26}");
        // ע�⣺Clear�������Ǵ�������ɾ�������
        // �෴�����ǽ�ÿһ����Ϊ��ǰ���͵�Ĭ��ֵ
        #region HIGHLIGHT
        Array.Clear(languages, 0, languages.Length);
        #endregion HIGHLIGHT
        Console.WriteLine($"{languages[0],-26}\t{languages[^1],-26}");
        Console.WriteLine(
        $"Clear�������С��: {languages.Length}");
        #endregion INCLUDE
    }
}

