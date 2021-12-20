namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_21
{
    public class Program
    {
        public static void Main()
        {
            string[] languages = new string[] {
                "C#", "COBOL", "Java",
                "C++", "TypeScript", "Visual Basic",
                "Python", "Lisp", "JavaScript" };
            // Save "C++" to variable called language
            string language = languages[3];
            // Assign "Java" to the C++ position
            languages[3] = languages[2];
            // Assign language to location of "Java"
            languages[2] = language;
        }
    }
}
