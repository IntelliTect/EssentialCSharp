namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_26;

public class ExceptionHandling
{
    #region INCLUDE
    public static void Main()
    {
        string? firstName;
        string ageText;
        int age;

        Console.WriteLine("Hey you!");

        Console.Write("Enter your first name: ");
        firstName = Console.ReadLine();

        #region HIGHLIGHT
        Console.Write("Enter your age: ");
        // Assume not null for clarity
        ageText = Console.ReadLine()!;
        age = int.Parse(ageText);

        Console.WriteLine(
            $"Hi { firstName }!  You are { age * 12 } months old.");
        #endregion HIGHLIGHT
    }
    #endregion INCLUDE
}
