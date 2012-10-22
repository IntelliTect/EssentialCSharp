namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_50
{
    public class Program
    {
        public static void Main()
        {
            string[] languages = new string[]{
                "C#", "COBOL", "Java",
                "C++", "Visual Basic", "Pascal",
                "Fortran", "Lisp", "J#"};
            System.Array.Sort(languages);
            string searchString = "COBOL";
            int index = System.Array.BinarySearch(
                languages, searchString);
            System.Console.WriteLine(
                "The wave of the future, {0}, is at index {1}.",
                searchString, index);

            System.Console.WriteLine();
            System.Console.WriteLine("{0,-20}\t{1,-20}",
                "First Element", "Last Element");
            System.Console.WriteLine("{0,-20}\t{1,-20}",
                "-------------", "------------");
            System.Console.WriteLine("{0,-20}\t{1,-20}",
                languages[0], languages[languages.Length - 1]);
            
            System.Array.Reverse(languages);
            System.Console.WriteLine("{0,-20}\t{1,-20}",
                languages[0], languages[languages.Length - 1]);
            
            // Note this does not remove all items from the array.
            // Rather it sets each item to the type’s default value.
            System.Array.Clear(languages, 0, languages.Length);
            System.Console.WriteLine("{0,-20}\t{1,-20}",
                languages[0], languages[languages.Length - 1]);
            System.Console.WriteLine(
                "After clearing, the array size is: {0}",
                languages.Length);
        }
    }
}
