namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_35;

public class LeveragingTryParse
{
    public static void Main()
    {
        string? firstName;
        string ageText;

        Console.Write("Enter your first name: ");
        firstName = Console.ReadLine();

        Console.Write("Enter your age: ");
        // Assume not null for clarity
        ageText = Console.ReadLine()!;
        #region INCLUDE
        if (int.TryParse(ageText, out int age))
        {
            Console.WriteLine(
                $"Hi { firstName }! " +
                $"You are { age * 12 } months old.");
        }
        else
        {
            Console.WriteLine(
                $"The age entered, { ageText }, is not valid.");
        }
        #endregion INCLUDE
    }
}
