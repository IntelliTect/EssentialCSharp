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
        Console.WriteLine("未来的浪潮，" + $"{searchString}，位于索引{index}。");
        Console.WriteLine();
        Console.WriteLine($"{"第一个元素",-26}\t{"最后一个元素",-26}");
        Console.WriteLine($"{"--------------",-26}\t{"--------------",-26}");
        Console.WriteLine($"{languages[0],-26}\t{languages[^1],-26}");
        #region HIGHLIGHT
        Array.Reverse(languages);
        #endregion HIGHLIGHT
        Console.WriteLine($"{languages[0],-26}\t{languages[^1],-26}");
        // 注意：Clear方法不是从数组中删除所有项，
        // 相反，它是将每一项设为当前类型的默认值
        #region HIGHLIGHT
        Array.Clear(languages, 0, languages.Length);
        #endregion HIGHLIGHT
        Console.WriteLine($"{languages[0],-26}\t{languages[^1],-26}");
        Console.WriteLine(
        $"Clear后，数组大小是: {languages.Length}");
        #endregion INCLUDE
    }
}

