namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_19
{
    public class Program
    {
        public static void Main()
        {
            string[] languages = new string[9] {
                "C#", "COBOL", "Java",
                "C++", "Visual Basic", "Pascal",
                "Fortran", "Lisp", "J#" };
            // Save "C++" to variable called language
            string language = languages[3];
            // Assign "Java" to the C++ position
            languages[3] = languages[2];
            // Assign language to location of "Java"
            languages[2] = language;
        }
    }
}
