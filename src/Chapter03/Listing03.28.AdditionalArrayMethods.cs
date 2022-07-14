namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_28
{
    #region INCLUDE
    public class ProgrammingLanguages
    {
        public static void Main()
        {
            string[] languages = new string[]{
                "C#", "COBOL", "Java",
                "C++", "TypeScript", "Swift",
                "Python", "Lisp", "JavaScript"};

            #region HIGHLIGHT
            System.Array.Sort(languages);
            #endregion HIGHLIGHT

            string searchString = "COBOL";
            #region HIGHLIGHT
            int index = System.Array.BinarySearch(
                languages, searchString);
            #endregion HIGHLIGHT
            System.Console.WriteLine(
                "The wave of the future, "
                + $"{ searchString }, is at index { index }.");

            System.Console.WriteLine();
            System.Console.WriteLine(
                $"{ "First Element",-20 }\t{ "Last Element",-20 }");
            System.Console.WriteLine(
                $"{ "-------------",-20 }\t{ "------------",-20 }");
            System.Console.WriteLine(
                    $"{ languages[0],-20 }\t{ languages[^1],-20 }");
            #region HIGHLIGHT
            System.Array.Reverse(languages);
            #endregion HIGHLIGHT
            System.Console.WriteLine(
                    $"{ languages[0],-20 }\t{ languages[^1],-20 }");
            // Note this does not remove all items from the array
            // Rather it sets each item to the type's default value
            #region HIGHLIGHT
            System.Array.Clear(languages, 0, languages.Length);
            #endregion HIGHLIGHT
            System.Console.WriteLine(
                    $"{ languages[0],-20 }\t{ languages[^1],-20 }");
            System.Console.WriteLine(
                $"After clearing, the array size is: { languages.Length }");
        }
    }
    #endregion INCLUDE
}

