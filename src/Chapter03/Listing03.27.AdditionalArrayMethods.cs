namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_27;

public class ProgrammingLanguages
{
    public static void Main()
    {
        #region INCLUDE
        string[] languages = new string[]{
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
        Console.WriteLine(
            "The wave of the future, "
            + $"{ searchString }, is at index { index }.");

        Console.WriteLine();
        Console.WriteLine(
            $"{ "First Element",-20 }\t{ "Last Element",-20 }");
        Console.WriteLine(
            $"{ "-------------",-20 }\t{ "------------",-20 }");
        Console.WriteLine(
                $"{ languages[0],-20 }\t{ languages[^1],-20 }");
        #region HIGHLIGHT
        Array.Reverse(languages);
        #endregion HIGHLIGHT
        Console.WriteLine(
                $"{ languages[0],-20 }\t{ languages[^1],-20 }");
        // Note this does not remove all items from the array
        // Rather it sets each item to the type's default value
        #region HIGHLIGHT
        Array.Clear(languages, 0, languages.Length);
        #endregion HIGHLIGHT
        Console.WriteLine(
                $"{ languages[0],-20 }\t{ languages[^1],-20 }");
        Console.WriteLine(
            $"After clearing, the array size is: { languages.Length }");
        #endregion INCLUDE
    }
}

